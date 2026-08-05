using EduCore.Application.DTOs.Auth;
using EduCore.Application.Interfaces;
using EduCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;

    private readonly IJwtService _jwtService;

    public AuthService(UserManager<ApplicationUser> userManager, IJwtService jwtService)
    {
        _userManager = userManager;
        _jwtService = jwtService;
    }

    public async Task RegisterAsync(RegisterRequest request)
    {
        var user = new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            throw new Exception("User Creation failed.");
        }

        await _userManager.AddToRoleAsync(user, "Student");

    }

    public async Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            throw new Exception("Invalid credentials");
        }

        var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!isPasswordValid)
        {
            throw new Exception("Invalid credentials");
        }

        var roles = await _userManager.GetRolesAsync(user);

        var token = await _jwtService.GenerateTokenAsync(user, roles);

        return new AuthResponse
        {
            Token = token
        };
    }
}


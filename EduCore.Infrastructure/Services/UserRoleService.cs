using EduCore.Application.Interfaces;
using EduCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Infrastructure.Services;

public class UserRoleService : IUserRoleService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserRoleService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> AssignRoleAsync(int userId, string role)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());

        if (user is null)
        {
            return false;
        }

        var roleExists = await _userManager.IsInRoleAsync(user, role);

        if (roleExists)
        {
            return true;
        }

        var result = await _userManager.AddToRoleAsync(user, role);

        return result.Succeeded;
    }
}


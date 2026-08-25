using EduCore.Application.Interfaces;
using EduCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace EduCore.Infrastructure.Services;

public class UserRoleService : IUserRoleService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;

    public UserRoleService(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<bool> AssignRoleAsync(int userId, string role)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());

        if (user is null)
        {
            return false;
        }

        var roleExists = await _roleManager.RoleExistsAsync(role);

        if (!roleExists)
        {
            return false;
        }

        var currentRole = await _userManager.GetRolesAsync(user);

        if (currentRole.Any())
        {
            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRole);

            if(!removeResult.Succeeded)
            {
                return false;
            }
        }

        var addResult = await _userManager.AddToRoleAsync(user, role);

        return addResult.Succeeded;
    }
}


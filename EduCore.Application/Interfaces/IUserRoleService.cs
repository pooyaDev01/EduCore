using EduCore.Application.DTOs.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Application.Interfaces;

public interface IUserRoleService
{
    Task<bool> AssignRoleAsync(int userId, string role);
    Task<IEnumerable<UserDto>> GetUsersAsync();
}


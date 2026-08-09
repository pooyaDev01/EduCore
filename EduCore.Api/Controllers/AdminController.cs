using EduCore.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCore.Api.Controllers;

[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly IUserRoleService _userRoleService;

    public AdminController(IUserRoleService userRoleService)
    {
        _userRoleService = userRoleService;
    }

    [HttpPost("users/{userid}/role")]
    public async Task<IActionResult> AssignRole(int userid,[FromForm] string role)
    {
        var result = await _userRoleService.AssignRoleAsync(userid, role);

        if (!result)
        {
            return BadRequest("Could not assign role");
        }

        return Ok("Role assigned successfully");
    }
}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCore.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult Authenticated()
    {
        return Ok("Authenticated.");
    }
    [Authorize(Roles = "Instructor")]
    [HttpGet("Instructor")]
    public IActionResult TeacherOnly()
    {
        return Ok("Welcome Instructor.");
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public IActionResult AdminOnly()
    {
        return Ok("Welcome Admin.");
    }
}


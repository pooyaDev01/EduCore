using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Application.DTOs.Admin;

public class UserDto
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public IList<string> Roles { get; set; } = new List<string>();
}

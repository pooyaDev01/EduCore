using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Application.Interfaces;

public interface IJwtService
{
    Task<string> GenerateTokenAsync(ApplicationUser user, IList<string> roles);
}


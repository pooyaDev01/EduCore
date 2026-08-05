using EduCore.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Application.Interfaces;

public interface IAuthService
{
    Task RegisterAsync(RegisterRequest request);

    Task<AuthResponse> LoginAsync(LoginRequest request);
}


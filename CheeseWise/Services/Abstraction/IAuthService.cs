﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseWise.Models;
using CheeseWise.Models.View;

namespace CheeseWise.Services.Abstraction
{
    public interface IAuthService
    {
        string HashPassword(string password);
        bool VerifyPassword(string actualPassword, string hashedPassword);
        string GetToken(User user, bool hasCompany);
        int GetUserIdFromToken(string token);
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace project.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace WebEShopFinal.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

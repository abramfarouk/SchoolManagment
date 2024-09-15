﻿using Microsoft.AspNetCore.Identity;

namespace SchoolManagment.Data.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        public string Address { get; set; }
        public string Country { get; set; }

    }
}

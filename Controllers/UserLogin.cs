﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tsupervan
{
    public class UserLogin
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
    }
}
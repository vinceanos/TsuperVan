using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tsupervan.Controllers
{
    public class UserRegister
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int RoleID { get; set; }
    }
}
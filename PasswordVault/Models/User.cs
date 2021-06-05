using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return "username: " + username + ", password: " + password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenlabDatabaseAndLogin
{
    public class User
    {
        public string Userid;
        public string Firstname;
        public string Lastname;
        public string Phone;
        public string Email;
        public string Role;
        public string Partner;

        public User(string userid, string firstname, string lastname, string phone, string email, string role, string partner)
        {
            Userid = userid;
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            Email = email;
            Role = role;
            Partner = partner;
        }
    }
}

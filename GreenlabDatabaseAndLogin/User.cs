using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenlabDatabaseAndLogin
{
    public class User
    {
        private string Userid;
        private string Firstname;
        private string Lastname;
        private string Phone;
        private string Email;
        private string Role;
        private string Partner;

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

        public string GetFirstName
        {
            get { return Firstname; }
        }

        public string GetLastName
        {
            get { return Lastname; }
        }

        public string GetPartner
        {
            get { return Partner; }
        }
    }
}

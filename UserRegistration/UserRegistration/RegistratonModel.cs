using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegistrationModel
    {
        public Regex FirstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex LastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex EmailID = new Regex(@"^[a-zA-Z0-9]+[-.+_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$");
        public Regex PhoneNumber = new Regex(@"[0-9]{1,2}[ ][0-9]{10}");
        public Regex PasswordRule1 = new Regex(@"[A-Za-z0-9]{8}");
        public Regex PasswordRule2 = new Regex(@"[A-Z]{1}[a-z0-9]{7}");
        public Regex PasswordRule3 = new Regex(@"[a-zA-Z][0-9]{1,}");
        public Regex PasswordRule4 = new Regex(@"^[A-Za-z0-9]{4}[!@#$%^&*]{1}[a-zA-Z0-9]{3}$");
    }
}

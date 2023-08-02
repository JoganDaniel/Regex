using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexOperations.UserRegistrationSystem
{
    public class UserRegistration
    {
        string nameRegex = "^[A-Z]{1}[a-z]{2,}$";
        string emailRegex = "^[a-z0-9]{1,}[._+-]{0,1}[a-z0-9]{0,}[@]{1}[a-z0-9]{1,}[.]{1}[a-z]{2,}[.]{0,1}[a-z]{0,}$";
        string mobileRegex = "^[0-9]{2}[ ][0-9]{10}$";
        string passwordRegex = "^[a-z0-9]{8}$";
        public void ValidateName(string name)
        {
            if(Regex.IsMatch(name, nameRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
        public void ValidateEmail(string mail)
        {
            if (Regex.IsMatch(mail, emailRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
        public void ValidateMobile(string number)
        {
            if (Regex.IsMatch(number, mobileRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
        public void ValidatePassword(string pass)
        {
            if (Regex.IsMatch(pass, passwordRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
    }
}

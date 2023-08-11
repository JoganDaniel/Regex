using System.Text.RegularExpressions;

namespace RegexOperations.UserRegistrationSystem
{
    public class UserRegistration
    {
        string nameRegex = "^[A-Z]{1}[a-z]{2,}$";
        string emailRegex = "^[a-z0-9]{1,}[._+-]{0,1}[a-z0-9]{0,}[@]{1}[a-z0-9]{1,}[.]{1}[a-z]{2,}[.]{0,1}[a-z]{0,}$";
        string mobileRegex = "^[0-9]{2}[ ][0-9]{10}$";
        //
        string passwordRegex = "^(?=^.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*#?&])[A-Za-z0-9]*[@$!%*#?&][A-Za-z0-9]*$";
        //
        public bool ValidateName(string name)
        {
            if(Regex.IsMatch(name, nameRegex))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID, false);
                //Console.WriteLine("Not valid");
                //return false;
            }
        }
        public bool ValidateEmail(string mail)
        {
            if (Regex.IsMatch(mail, emailRegex))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID, false);
                //Console.WriteLine("Not valid");
                //return false;
            }
        }
        public bool ValidateMobile(string number)
        {
            if (Regex.IsMatch(number, mobileRegex))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID, false);
                //Console.WriteLine("Not valid");
                //return false;
            }
        }
        public bool ValidatePassword(string pass)
        {
            if (Regex.IsMatch(pass, passwordRegex))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID, false);
                //Console.WriteLine("Not valid");
                //return false;
            }
        }
        public bool ValidateNameRegex(string input) => Regex.IsMatch(input, nameRegex) ? true : false;
        public bool ValidateEmailRegex(string input) => Regex.IsMatch(input, emailRegex) ? true : false;
        public bool ValidateMobileRegex(string input) => Regex.IsMatch(input, mobileRegex) ? true : false;
        public bool ValidatePasswordRegex(string input) => Regex.IsMatch(input, passwordRegex) ? true : false;
    }
}

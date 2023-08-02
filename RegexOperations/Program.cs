using RegexOperations.UserRegistrationSystem;
using System;
using System.Windows.Markup;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Aweff";
        static string lastName = "Wfdfw";
        static string email = "j@d.com";
        static string mobile = "91 8765423878";
        static string password = "vvhsg77kAk";

        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
            Console.WriteLine(lastName);
            validate.ValidateName(lastName);
            Console.WriteLine(email);
            validate.ValidateEmail(email);
            Console.WriteLine(mobile);
            validate.ValidateMobile(mobile);
            Console.WriteLine(password);
            validate.ValidatePassword(password);
        }
    }
}
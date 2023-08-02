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
        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
            Console.WriteLine(lastName);
            validate.ValidateName(lastName);
            Console.WriteLine(email);
            validate.ValidateEmail(email);
        }
    }
}
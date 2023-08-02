using RegexOperations.UserRegistrationSystem;
using System;
using System.Windows.Markup;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Aweff";
        
        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
          
        }
    }
}
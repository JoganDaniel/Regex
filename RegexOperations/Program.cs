using System;
namespace RegexOperations
{
    public class Program
    {
        static string email = "jojojo";
        private static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            validateEmail.uc1Validate(email);
            
        }
    }
}
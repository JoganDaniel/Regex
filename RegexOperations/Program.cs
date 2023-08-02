using System;
namespace RegexOperations
{
    public class Program
    {
        static string email1 = "abc";
        static string email2 = "@bridgelabz";

        private static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            validateEmail.uc2Validate(email);
            
        }
    }
}
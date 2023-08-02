using System;
namespace RegexOperations
{
    public class Program
    {
        static string email1 = "abc";
        static string email2 = "@bridgelabz";
        static string email3 = ".com";

        private static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            validateEmail.uc1Validate(email1);
            validateEmail.uc2Validate(email2);
            validateEmail.uc3Validate(email3);
        }
    }
}
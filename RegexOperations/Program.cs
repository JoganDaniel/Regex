using System;
namespace RegexOperations
{
    public class Program
    {
        static string email1 = "abc";
        static string email2 = "@bridgelabz";
        static string email3 = ".com";
        static string email4 = "abc.hh@bridgelabz.com";
        static string email5 = "abc.hh@bridgelabz.com";


        private static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            validateEmail.uc1Validate(email1);
            validateEmail.uc2Validate(email2);
            validateEmail.uc3Validate(email3);
            validateEmail.uc4Validate(email4);

        }
    }
}
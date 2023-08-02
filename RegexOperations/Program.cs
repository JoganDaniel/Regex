using System;
using System.Windows.Markup;

namespace RegexOperations
{
    public class Program
    {
        //static string email1 = "abc";
        //static string email2 = "@bridgelabz";
        //static string email3 = ".com";
        //static string email4 = "abc.hh@bridgelabz.com";
        //static string email5 = "abc.de@bridgelabz.co.in";
        static string[] emails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
        
        private static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            //validateEmail.uc1Validate(email1);
            //validateEmail.uc2Validate(email2);
            //validateEmail.uc3Validate(email3);
            //validateEmail.uc4Validate(email4);
            //validateEmail.uc5Validate(email5);
            foreach (string email in emails)
            {
                Console.WriteLine(email);
                validateEmail.uc5Validate(email);
            }
        }
    }
}
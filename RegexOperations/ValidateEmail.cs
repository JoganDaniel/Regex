using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexOperations
{
    public class ValidateEmail
    {

        string uc1Regex = "^[a-z]{0,}$";
        string uc2Regex = "^[@]{1}[a-z]{1,}$";
        string uc3Regex = "^[.]{1}[a-z]{2,3}$";
        string uc4Regex = "^[a-z]+[._+-]{0,1}[a-z]&";
        string actualRegex = "^[a-z]+([._+-]{0,1}[a-z]+[@]";
        public void uc1Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc2Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc2Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc3Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc3Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc4Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
    }
}

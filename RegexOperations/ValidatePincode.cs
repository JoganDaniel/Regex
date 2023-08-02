using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexOperations
{
    public class ValidatePincode
    {
        string uc1_Regex = "^[0-9]{6}$";
        string uc4_Regex = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";

        public void uc1Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc2Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc3Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc4Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4_Regex);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
    }
}

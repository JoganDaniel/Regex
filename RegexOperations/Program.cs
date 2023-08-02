using System;
namespace RegexOperations
{
    public class Program
    {
        static string pincode = "765876";
        private static void Main(string[] args)
        {
            ValidatePincode validatePincode = new ValidatePincode();
            validatePincode.uc1Validate(pincode);
            validatePincode.uc2Validate(pincode);
            validatePincode.uc3Validate(pincode);
            validatePincode.uc4Validate(pincode);
        }
    }
}
using System;

namespace UC1simplePincode
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pin;
            bool result;
            SimplePinValidate simplepinvalidate = new SimplePinValidate();
            Console.WriteLine("Enter Pincode: ");
            Pin = Console.ReadLine();
            result = simplepinvalidate.simplePin(Pin);
            Console.WriteLine(result);
        }
    }
}

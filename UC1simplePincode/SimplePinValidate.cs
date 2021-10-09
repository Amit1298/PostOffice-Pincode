using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1simplePincode
{
    class SimplePinValidate
    {
        public string RagexPattern = "^[0-9]{6}$";
        public bool simplePin(string pincode)
        {
            return Regex.IsMatch(pincode, RagexPattern);
        }
    }
}

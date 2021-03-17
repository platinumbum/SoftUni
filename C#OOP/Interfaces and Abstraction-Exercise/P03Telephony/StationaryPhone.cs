using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}

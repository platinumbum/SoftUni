using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }

            return $"Calling... {number}";
        }
    }
}

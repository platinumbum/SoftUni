using System;
using System.Collections.Generic;
using System.Text;

namespace P03ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exeptionMessage)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exeptionMessage);
            }
        }

        public static void ThrowIfNumberIsNegative(decimal number, string exeptionMessage)
        {
            if (number < 0)
            {
                throw new ArgumentException(exeptionMessage);
            }
        }
    }
}

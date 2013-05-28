using System;
using System.Collections.Generic;
using System.Globalization;

namespace WindowsFormsApplication1
{
    internal class RandomGenerator<T>
    {
        Random _random = new Random();

        public T Generate()
        {
            if (typeof (T) == typeof (string))
            {
                var randomNumber = _random.Next();
                var randomString = GenerateStringFromNumber(randomNumber);
                return (T)(object)randomString;
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)_random.Next();
            }

            if (typeof(T) == typeof(Guid))
            {
                return (T)(object)(Guid.NewGuid());
            }
            
            throw new NotSupportedException("Given type is not supported");
        }

        private static string GenerateStringFromNumber(int number)
        {
            var charList = new Stack<char>();
            var currentDigit = number%10;
            var quotient = number - currentDigit;
            while (quotient > 0)
            {
                // Use the currentDigit
                charList.Push((char)(currentDigit + 'a'));
                
                // Get next set of params
                quotient = quotient/10;
                currentDigit = quotient%10;
                quotient = quotient - currentDigit;
            }

            return new string(charList.ToArray());
        }
    }
}
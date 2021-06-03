using System;

namespace P02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowsCounter(input));
            
        }

        private static int VowsCounter(string input)
        {
            int vowCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                
                if (currentLetter == 'a' 
                    || currentLetter == 'e' 
                    || currentLetter == 'i' 
                    || currentLetter == 'o' 
                    || currentLetter == 'u')
                {
                    vowCount++;
                }
            }
            return vowCount;
        }
    }
}

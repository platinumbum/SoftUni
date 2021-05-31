using System;

namespace P02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            foreach (var element2 in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (element2 == arr1[i])
                    {
                        Console.Write(element2 + " ");
                        break;
                    }
                }
            }
        }
    }
}

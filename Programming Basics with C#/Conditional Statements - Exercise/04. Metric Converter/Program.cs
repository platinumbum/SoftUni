using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metricInput = Console.ReadLine();
            string metricOutput = Console.ReadLine();

            if (metricInput == "m" && metricOutput == "mm")
            {
                Console.WriteLine($"{(number * 1000):f3}");
            }
            else if (metricInput == "m" && metricOutput == "cm")
            {
                Console.WriteLine($"{(number * 100):f3}");
            }
            else if (metricInput == "cm" && metricOutput == "m")
            {
                Console.WriteLine($"{(number * 0.01):f3}");
            }
            else if (metricInput == "cm" && metricOutput == "mm")
            {
                Console.WriteLine($"{(number * 10):f3}");
            }
            else if (metricInput == "mm" && metricOutput == "m")
            {
                Console.WriteLine($"{(number * 0.001):f3}");
            }
            else if (metricInput == "mm" && metricOutput == "cm")
            {
                Console.WriteLine($"{(number * 0.1):f3}");
            }
        }
    }
}

using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Exercises_Strings_and_Text_Processing
{
    class Program
    {
        private static object converted;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int ubase = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            StringBuilder remainders = new StringBuilder();

            while (number > 0)
            {
                remainders.Append(number % ubase);
                number /= ubase;

            }
            Console.WriteLine(string.Concat(remainders.ToString().Reverse()));
            //for (int i = converted.Lenght -1; i >= 0; i--)
            // {
            //    Console.WriteLine($"{converted[i]}");
           // }     
        }
    }
}

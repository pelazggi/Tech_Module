using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Problem_1._Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int @base = int.Parse(input[0]);//purvoto ni e osnovata, eskeipvame go
            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);
            StringBuilder converted = new StringBuilder();
            
            while(number > 0)
            {
                BigInteger remainder = number % @base;
                converted.Append(remainder);
                number /= @base;
                

            }
            for (int i = converted.Length -1; i >=0; i--)// trqbva da oburnem cikula
            {
                Console.WriteLine(converted[i]);
            }
            
        }
    }
}

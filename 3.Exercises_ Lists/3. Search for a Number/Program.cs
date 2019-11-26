using System;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var comands = Console.ReadLine()
                .Split(' ').
                Select(int.Parse)
                .ToList();

            bool isOK = true;
            int start = comands[1];
            int end = comands[0];

            for (int i = start; i < end; i++)
            {
                if (input[i] == comands[2])
                {
                    Console.WriteLine("YES!");
                    isOK = false;
                }
            }
            if (isOK)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
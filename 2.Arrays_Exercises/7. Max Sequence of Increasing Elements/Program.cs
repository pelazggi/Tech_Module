using System;
using System.Linq;

namespace _7._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
            }
            for (int i = maxStart; i < maxStart + maxLen; i++)
                Console.Write("{0} ", numbers[i]);
        }
    }
}

        

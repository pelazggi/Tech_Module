using System;
using System.Linq;
using System.Text;


namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int difference = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentDigit = numbers[i];

                for (int j = i; j < numbers.Length; j++)
                {
                    if (Math.Abs(currentDigit - numbers[j]) == difference)
                    {
                      result++;
                    }

                }
            }
        }
        Console.WriteLine(result);

    }
}

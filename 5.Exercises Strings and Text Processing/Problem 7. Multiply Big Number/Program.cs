using System;
using System.Linq;
using System.Text;

namespace Problem_7._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int multiplayer = 0;
            int remainder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length-1; i >= 0; i--)
            {
                multiplayer = num1[i] - 48 * num2 + remainder;
                num = multiplayer % 10;
                if (multiplayer > 9)
                {
                    remainder = multiplayer / 10;
                }
                else
                {
                    remainder = 0;
                }
                sb.Append(num);
            }
            if(remainder > 0)
            {
                sb.Append(remainder);
            }
            Console.WriteLine(sb.ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray());
        }
    }
}

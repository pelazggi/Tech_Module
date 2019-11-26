﻿using System;

namespace Problem_12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumMax = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for(int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    counter++;
                    if (sum >= sumMax)
                    {
                        Console.WriteLine($"{counter} combinations\r\nSum: {sum} >= {sumMax}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations\r\nSum: {sum}");
        }
    }
}

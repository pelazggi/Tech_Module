﻿using System;

namespace Problem_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if(first + 5 >= second)
            {
                Console.WriteLine("No");
                return;
            }
            for(int i = first; i < second - 4; i++  )
            {
                for (int j = first + 1; j < second - 3; j++)
                {
                    for (int k = first + 2; k < second - 2; k++)
                    {
                        for (int l = first + 3 ; l < second - 1; l++)
                        {
                            for (int m = first + 4; m < second ; i++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
             }


            Console.WriteLine("Hello World!");
        }
    }
}

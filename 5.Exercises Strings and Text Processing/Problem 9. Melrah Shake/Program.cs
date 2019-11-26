﻿using System;

namespace Problem_9._Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            var canMelrahShake = true;

            while (canMelrahShake)
            {
                var firstIndex = input.IndexOf(pattern);
                var lastIndex = input.LastIndexOf(pattern);

                if (firstIndex > -1 && lastIndex > -1 && pattern.Length > 0)
                {
                    firstIndex = input.IndexOf(pattern);
                    input = input.Remove(firstIndex, pattern.Length);
                    lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    canMelrahShake = false;
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}
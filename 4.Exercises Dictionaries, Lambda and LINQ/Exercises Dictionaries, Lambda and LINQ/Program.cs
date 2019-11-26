using System;
using System.Collections.Generic;

namespace Exercises_Dictionaries__Lambda_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> secuence = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!secuence.ContainsKey(resource)) //purvoto ne6to e da napravim proverka
                {
                    secuence.Add(resource, 0);
                }
                secuence[resource] += quantity;

                resource = Console.ReadLine();
            }

                foreach (var item in secuence)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                    
            
        }
    }
}

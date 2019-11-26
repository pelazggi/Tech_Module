using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Legendary_Farming
{
    class Program
    {
        private static object metal;

        static void Main(string[] args)
        {
            
            bool shadowmourne = false;
            bool valanyr = false;
            bool dragonwrath = false;
            string resource;
            int quantity = 0;
            string result = "";


            Dictionary<string, int> resourcesPrimary = new Dictionary<string, int>();
            resourcesPrimary.Add("Shards", 0);
            resourcesPrimary.Add("Motes", 0);
            resourcesPrimary.Add("Fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (shadowmourne == false && valanyr == false && dragonwrath == false)
            {
                string[] input = Console.ReadLine()
                   .Split(' ')
                   .ToArray();

                for (int i = 0; i < input.Length; i++)
                {

                    resource = input[i+1].ToLower();
                    quantity = int.Parse(input[i]);

                    if (resourcesPrimary.ContainsKey(resource))
                    {
                        resourcesPrimary[resource] += quantity;
                    }
                    else if (!junk.ContainsKey(resource))
                    {
                        junk.Add(resource, quantity);
                    }
                    else
                    {
                        junk[resource] += quantity;
                    }

                    if (resourcesPrimary["shards"] >= 250)
                    {
                        shadowmourne = true;
                        result = "Shadowmourne";
                        resourcesPrimary["shards"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["fragments"] >= 250)
                    {
                        valanyr = true;
                        result = "Valanyr";
                        resourcesPrimary["fragments"] -= 250;
                        break;

                    }
                    else if (resourcesPrimary["motes"] >= 250)
                    {
                        dragonwrath = true;
                        result = "Dragonwrath";
                        resourcesPrimary["motes"] -= 250;
                        break;
                    }

                }
            }
                   Console.WriteLine(value: $"{result} Obtained!");
                foreach (var metal in resourcesPrimary.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{metal.Key}: {metal.Value}");
                }

                foreach (var metal in junk.OrderBy(x => x.Key))
                 {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
                 }

        }

    }
}

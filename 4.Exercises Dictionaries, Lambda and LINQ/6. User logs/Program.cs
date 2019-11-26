using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._User_logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            var address = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var items = input.Split(' ', '=').ToArray();
                var username = items.Last();
                var ip = items[1];
                var count = 1;
                if (!dictionary.ContainsKey(username))
                {
                    address = new Dictionary<string, int>();
                    address[ip] = count;
                    dictionary[username] = address;
                }
                else if (dictionary.ContainsKey(username))
                {
                    if (!address.ContainsKey(ip))
                    {
                        address[ip] = count;
                    }
                    else if (address.ContainsKey(ip))
                    {
                        var currentValue = 0;
                        address.TryGetValue(ip, out currentValue);
                        address[ip] = count + currentValue;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var users in dictionary)
            {
                Console.WriteLine($"{users.Key}: ");
                foreach (var addresses in users.Value)
                {
                    if (addresses.Equals(users.Value.Last()))
                    {
                        Console.WriteLine($"{addresses.Key} => {addresses.Value}.");
                        break;
                    }
                    Console.Write($"{addresses.Key} => {addresses.Value}, ");
                }
            }
        }
    }
}
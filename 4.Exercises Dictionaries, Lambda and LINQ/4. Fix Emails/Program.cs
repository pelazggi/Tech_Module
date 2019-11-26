using System;
using System.Collections.Generic;

namespace _4._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contact = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!contact.ContainsKey(name))
                {
                    contact.Add(name, email);
                }
                if (email.EndsWith(".us") || email.EndsWith(".uk"))
                {
                    contact.Remove(name);
                }
                name = Console.ReadLine();
            }

            foreach (var item in contact)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

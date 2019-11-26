using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.__Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] comands = Console.ReadLine()// kaomandite gi pravim kato masiv
                .Split(" ")
                .ToArray();

            //purvo tr da znaem koga svur6va programata
            while (comands[0] != "END")// pi6em poziciqta, z e masiv
            {
                if (comands[0] == "A")
                {
                    if (!phonebook.ContainsKey(comands[1]))
                    {
                        phonebook.Add(comands[1], comands[2]);
                    }
                    else
                    {
                        phonebook[comands[1]] = comands[2];
                    }
                }
                else if (comands[0] == "S")
                {
                    if (!phonebook.ContainsKey(comands[1]))
                    {

                        Console.WriteLine($"Contact {comands[1]} does not exist");
                    }

                    else
                    {
                        Console.WriteLine($"{comands[1]} -> {phonebook[comands[2]]}");
                    }
                }
                else if (comands[0] == "ListAll")
                {
                    foreach( var pair in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }

                }
                comands = Console.ReadLine()
                    .Split(" ")
                    .ToArray(); // za da ne se vurti cikula do bezkrainost
            }
        }
    }
}

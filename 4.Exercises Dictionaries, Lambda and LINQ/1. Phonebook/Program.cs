using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] comands = Console.ReadLine()// kaomandite gi pravim kato masiv
                .Split(' ')
                .ToArray();

            //purvo tr da znaem koga svur6va programata
            while(comands[0] != "END")// pi6em poziciqta, za6toto e masiv
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
            }
        }
    }
}

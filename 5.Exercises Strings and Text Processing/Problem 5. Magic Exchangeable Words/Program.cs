using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine()
                 .Split(' ')
                 .ToArray();

            string word1 = words[0];
            string word2 = words[1];

            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            int

            for (int i = 0; i < Math.Max(word1.Length, word2.Length; i++)
            {
                char word1Char = word1[i];
                char word2Char = word1[i];

                if (dictionary.Contains(word1Char) == false)
                {
                    dictionary.Add(word1Char, word2Char);
                }
                else
                {
                    char oldValue = dictionary{word1Char};

                    if (word2Char != oldValue)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}

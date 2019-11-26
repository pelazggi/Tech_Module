using System;

namespace _2._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine()
                                        .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
            string pattern = $@"\b{word}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
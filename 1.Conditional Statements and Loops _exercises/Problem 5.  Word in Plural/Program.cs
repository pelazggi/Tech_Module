using System;

namespace Problem_5.__Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.EndsWith('y'))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";
            }
            else if(word.EndsWith('z')||word.EndsWith('s')||word.EndsWith('x')
                ||word.EndsWith("ch")||word.EndsWith("sh")||word.EndsWith('o'))
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }
            Console.WriteLine($"{word}");
        }
    }
}

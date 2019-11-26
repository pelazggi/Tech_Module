using System;
using System.Linq;

namespace _5._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           char[] words1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
           char[] words2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool isFirst = false;

            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[i] < words2[i])
                {
                    isFirst = true;
                    break; // za6toto ni interesuva samo purvata bukva
                }
                else if (words1[i] > words2[i])
                {
                    isFirst = false;
                    break;
                }
                if (i == Math.Min(words1.Length, words2.Length) - 1)
                {
                    if (words1.Length < words2.Length)
                    {
                        isFirst = true;
                    }
                    else
                    {

                        isFirst = false;
                    }
                }
            }

                if(isFirst)
                {
                    Console.WriteLine(string.Join("", words1));
                    Console.WriteLine(string.Join("", words2));
                }
                else
                {

                    Console.WriteLine(string.Join("", words2));
                    Console.WriteLine(string.Join("", words1));
                }
             
        }
    }
}

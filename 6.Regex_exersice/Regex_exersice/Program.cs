using System;

namespace Regex_exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s[A-Za-z0-9]+\.?-?\w+?@\w+-?\.?(\w+)?\.?(\w+)?\.\w+";
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value.Trim());
            }
        }
    }
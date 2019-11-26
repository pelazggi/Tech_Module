using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();
        int sum = 0;
        foreach (string number in numbers)
        {
            char[] array = number.ToCharArray();
            array = array.Reverse().ToArray();
            int num = int.Parse(new string(array));
            sum += num;
        }

        Console.WriteLine(sum);
    }
}

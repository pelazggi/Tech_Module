using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToList();
            int[] comand = Console.ReadLine()
                  .Split(' ')
                  .Select(int.Parse)
                  .ToArray();
            List<int> newList = new List<int>();

            int takeNum = comand[0];
            int deleteNums = comand[1];
            int searchNum = comand[2];

            for (int i = 0;  i< takeNum; i++)
            {
                newList.Add(input[i]);
            }
            for (int i = 0; i < deleteNums; i++)
            {
                newList.RemoveAt(0);
            }
            if (newList.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }          
    }
}

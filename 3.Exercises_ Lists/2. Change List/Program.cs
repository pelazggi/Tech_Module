using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Even" && inputLine != "Odd")
            {

                string[] command = inputLine
                    .Split(' ')
                    .ToArray();

                if (command[0] == "Delete")
                {
                    int numDelete = int.Parse(command[1]);

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        inputList.Remove(numDelete);

                    }


                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    inputList.Insert(index, element);
                }
                inputLine = Console.ReadLine();
            }
            List<int> result = new List<int>();
            if (inputLine == "Odd")
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 != 0)
                    {
                        result.Add(inputList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if ( inputList[i] % 2 == 0)
                    {
                        result.Add(inputList[i]);
                    }
                }
            }
            Console.Write(string.Join(" ", result));
        }
    }
    
}

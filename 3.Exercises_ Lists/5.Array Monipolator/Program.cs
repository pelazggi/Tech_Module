using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            while (true)
            {
                string line = Console.ReadLine();

                if(line == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", nums));// predi break da si printirame
                        break;
                }
                string[] arr = line.Split();// сплитваме командата по спейсче

                string comand = arr[0];// purvo e comandata
                int index;
                int element;

                switch (comand)
                {
                    case "add":
                        index = int.Parse(arr[1]);
                        element = int.Parse(arr[2]);
                        nums.Insert(index, element);
                        break;

                    case "addMany":// neznaem kolko sa elementi
                        index = int.Parse(arr[1]);

                        List<int> numbersToAdd = new List<int>();// pravim nov list

                        for (int i = 2; i < arr.Length; i++)// ot d2 do duljinata na arr 
                        {
                            numbersToAdd.Add(int.Parse(arr[i]));
                        }

                        nums.InsertRange(index, numbersToAdd);
                        break;

                    case "contains":
                        element = int.Parse(arr[1]);// elementa, koito e daden
                        index = nums.IndexOf(element);// na koi index se namira tozi element
                        Console.WriteLine(index);// ako nqma takuv vru6ta -1, ako ne samiq index
                        break;

                    case "remove":
                        index = int.Parse(arr[1]);
                        nums.RemoveAt(index);
                        break;

                    case "shift":

                        int rotations = int.Parse(arr[1]);
                        Shift(nums, rotations);
                        break;

                    case "sumPairs":
                        SumPairs(nums);
                        break;

                }
            }
        }

        private static void SumPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
        }

        private static void Shift(List<int> nums, int rotations)
        {
            for (int i = 0; i < rotations % nums.Count; i++)// ako polu4a 5 rotacii masiva nqma da se promeni
            {
                int first = nums[0];
                nums.RemoveAt(0);
                nums.Add(first);
            }
        }
    }
}
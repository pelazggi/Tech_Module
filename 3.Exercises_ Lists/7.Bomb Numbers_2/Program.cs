using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Bomb_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[]bombNumbers = Console.ReadLine()//4etem bomba parametri
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombNumbers[0]; //bombandira6toto 4islo
            int range = bombNumbers[1];

            int bombIndex = nums.IndexOf(bombNumber);// namirame na koi index se

            while(bombIndex != -1)// poneje indexof vru6ta -1
            {
                int leftIndex = bombIndex - range;//vzimame index
                int rightIndex = bombIndex + range;

                if (leftIndex < 0)//ako sme izvun granicite na masiva
                {
                    leftIndex = 0;// da sprem izlizaneto ot masiva
                }
                if(rightIndex > nums.Count - 1)//su6toto e i ot drugata strana
                {
                    rightIndex = nums.Count - 1;
                }
                int count = rightIndex - leftIndex + 1;
                nums.RemoveRange(leftIndex, count);

                bombIndex = nums.IndexOf(bombNumber);
            }
            int sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
   
        }
    }
}

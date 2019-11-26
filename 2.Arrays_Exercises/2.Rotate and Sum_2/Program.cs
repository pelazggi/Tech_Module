using System;
using System.Linq;

namespace _2.Rotate_and_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int numberOfRotations = int.Parse(Console.ReadLine());
                int[] sum = new int[numbers.Length];// nov masiv sum


                for (int i = 0; i < numberOfRotations; i++)//vurtim masiva
                {
                    numbers = Rotate(numbers);//всеки път трябва да вкарваме numbers, а не ротейдет
                    for (int j = 0; j < numbers.Length; j++)//tuk pulnim masiva sum
                    {
                        sum[j] += numbers[j];
                    }
                }
                Console.WriteLine(string.Join(' ', sum));
            }

            static int[] Rotate(int[] numbers)
            {
                int[] rotated = new int[numbers.Length];//purvo suzdavame masiva
                int last = numbers[numbers.Length - 1];
                for (int i = 1; i < rotated.Length; i++)
                {
                    rotated[i] = numbers[i - 1];//poneje imame -1 stava opasno i slagame cikala da e edno
                }
                rotated[0] = last;
                return rotated;

            }
        }
    }
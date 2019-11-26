using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();// 4etem list

            int counter = 1;// countara e 1, za6toto e purvona4alniqt broi

            int counterMax = 0;//recorda pomni
            int numberMax= 0;//koi napravi recorda
           
            //vurtim cikul
            for (int i = 0; i < numbers.Count - 1; i++)//vurti cuztezatelite
            {
                // ako ima poredni 4isla
                if (numbers[i] == numbers[i + 1])
                {
                    // uveli4avame broq
                    counter ++;

                    if (counter > counterMax) //pove4e li e ot recorda
                    {
                        counterMax = counter;// recorda pridobiva noviq record
                        numberMax = numbers[i];// za da znaen koe 4islo e postavilo noviqt record
                    }
                }
                else

                {
                    counter = 1;
                }

                if (counter > counterMax)//kogato ne sme vlizali v if-a, za6toto ne se povtarqt 4islata
                {
                    counterMax = counter;
                    numberMax = numbers[i];
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax + " ");
            }
            Console.WriteLine();
        }

    }
}

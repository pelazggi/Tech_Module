using System;

namespace Problem15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 1;

            while(peshoHealth > 0 && goshoHealth >0)
            {
                 if(round % 2 == 1)
                 {
                    goshoHealth -= peshoDamage;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                 }
                 else
                 {
                    peshoHealth -= goshoDamage;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");

                 }
                 if(round % 3 == 0 && peshoHealth > 0 && goshoHealth > 0)
                 {
                    peshoHealth += 10;
                    goshoHealth += 10;

                 }
                round++;

            }
            if (round % 2 == 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}

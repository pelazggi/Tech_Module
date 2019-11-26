using System;

namespace Problem_8._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
             int calories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "Tomato sauce":
                        calories += 150;
                        break;
                    case "Salami":
                        calories += 600;
                        break;
                    case "Pepper":
                        calories += 50;
                        break;
                }

            }

        Console.WriteLine($"Total calories:{calories}");
        }
    }
}

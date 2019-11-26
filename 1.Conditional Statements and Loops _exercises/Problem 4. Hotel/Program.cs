using System;

namespace Problem_4._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch(month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nights > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    if (month == "October" && nights > 7)
                    {
                        priceStudio = 50.00 * (nights - 1);
                    }
                    break;
                case "June":
                case "Semteber":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if(nights > 14)
                    {
                        priceDouble *= 0.90;
                    }
                    if (month == "September" && nights >=7)
                    {
                        priceStudio = 60.00 * (nights - 1);
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nights > 14)
                    {
                        priceDouble *= 0.85;
                    }
                    break;
             }
            if ((month == "Semteber" || month == "October") && (nights > 7))
            {
                priceStudio *= (1 - (1.0 /nights)); 
            }

               Console.WriteLine($"Studio: {priceStudio * nights:F2} lv.\r\nDouble: { priceDouble * nights:F2} lv.\r\nSuite: { priceSuite*nights:F2} lv.");
                  
        }
    }
}

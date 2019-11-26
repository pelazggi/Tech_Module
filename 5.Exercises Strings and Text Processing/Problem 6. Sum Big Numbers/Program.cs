using System;
using System.Linq;
using System.Text;

namespace Problem_6._Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //cubirame dve 4isla
            string num1 = Console.ReadLine();//4etem ot vxoda
            string num2 = Console.ReadLine();
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');
            //if(num1.Length > num1.Length)
            // {
            //    num2 = num2.PadLeft(num1.Length, '0');//dobavqme nuli otpred za po-lesno smqtane
            // }
            //else
            //  {
            //     num1 = num1.PadLeft(num2.Length, '0');
            //  }

            StringBuilder sb = new StringBuilder();

            int sum = 0;
            int remainder = 0;
            int num = 0;
            
            for (int i = maxLength - 1; i >=0; i--)
            {
                int firstDigit = int.Parse(num1[i].ToString());
                int secondDigit =int.Parse(num2[i].ToString)
                sum = num1[i] - 48 + num2[i] - 48 + remainder;
                num = sum % 10;
                if (sum > 9)
                {
                    remainder = 1;
                }
                else
                {
                    remainder = 0;
                }
                sb.Append(num);
                if (i == 0 && remainder == 1)
                {
                    sb.Append(remainder);
                }
               

            }
            Console.WriteLine(sb.ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray());

        }
    }
}

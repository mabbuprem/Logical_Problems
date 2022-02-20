using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coupon numbers");
            Console.WriteLine("enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            GetRandom(number);
        }

        public static void GetRandom(int number)
        {
            int[] Array = new int[number];
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                bool same = false;
                Random random = new Random();
                int randomNum = random.Next(100, 999);

                foreach (int num in Array)
                {
                    if (num == randomNum)
                    {
                        same = true;
                        break;
                    }

                }
                if (same == true && i > 0)
                {
                    i--;
                }
                else
                {
                    Array[i] = randomNum;
                }
                count++;
            }
            Console.WriteLine($"total number of iterations: {count}");
            Console.WriteLine(String.Join(" ", Array));
        }

    }
}

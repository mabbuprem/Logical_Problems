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
            Console.WriteLine("calculate square root using newtons method");
            Console.WriteLine("enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            GetRoot(number);
        }
        public static void GetRoot(double number)
        {
            double answer = number;
            while ((Math.Abs(answer - number / answer)) > (1e-15 * answer))
            {
                answer = (answer + (number / answer)) / 2;
            }
            Console.WriteLine(answer);
        }
    }
}

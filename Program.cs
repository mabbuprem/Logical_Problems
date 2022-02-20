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
            Console.WriteLine("calculate monthly payment");
            Console.WriteLine("enter principal amount");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter years");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter percent interest");
            double R = Convert.ToDouble(Console.ReadLine());
            Calculate(P, Y, R);
        }

        public static void Calculate(double P, double Y, double R)
        {
            /*double r = R / (12 * 100);
              double n = 12 * Y;
              double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));*/
            double totalAmount = P * (Math.Pow(1 + (R / 100), Y));
            double EMI = totalAmount / (Y * 12);
            Console.WriteLine(EMI);
        }
    }
}
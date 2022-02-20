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
            Console.WriteLine("reverse number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int remainder = Number;
            int tenth = 1;
            int reverse = 0;
            while (remainder > 10)
            {
                remainder = remainder / 10;
                tenth *= 10;
            }
            remainder = Number;
            while (remainder > 0)
            {
                int digit = remainder % 10;
                remainder = remainder / 10;
                reverse += digit * tenth;
                tenth /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}

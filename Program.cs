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
            Console.WriteLine("decimal to binary");
            Console.WriteLine("enetr number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Binary binary = new Binary();
            binary.GetBinary(number);
        }
    }
}
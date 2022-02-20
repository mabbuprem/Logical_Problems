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
            Console.WriteLine("Welocome to Logical Programs");
            Console.Write("Enter last number of the series: ");
            //VARIABLES
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            int i = 0;
            int k = 0;

            Console.Write(i + " " + j + " ");
            while (k < lastNumber - i)
            {
                k = j + i;
                Console.Write(k + " ");
                i = j;
                j = k;
            }
        }
    }
}

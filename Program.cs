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
        
                Console.WriteLine("day of week");
                Console.WriteLine("enter day");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter month");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter year");
                int y = Convert.ToInt32(Console.ReadLine());
                GetWeek(d, m, y);
            }
            public static void GetWeek(int d, int m, int y)
            {
                int y1 = y - (14 - m) / 12;
                int x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
                int m1 = m + 12 * ((14 - m) / 12) - 2;
                int d1 = (d + x + 31 * m1 / 12) % 7;

                switch (d1)
                {
                    case 0:
                        Console.WriteLine("sunday");
                        break;
                    case 1:
                        Console.WriteLine("monday");
                        break;
                    case 2:
                        Console.WriteLine("tuesday");
                        break;
                    case 3:
                        Console.WriteLine("wednesday");
                        break;
                    case 4:
                        Console.WriteLine("thursday");
                        break;
                    case 5:
                        Console.WriteLine("friday");
                        break;
                    case 6:
                        Console.WriteLine("saturday");
                        break;
                }
            }
        }
    }
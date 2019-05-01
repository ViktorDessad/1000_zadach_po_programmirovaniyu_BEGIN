using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int point_x1 = 10;
            int point_x2 = 14;
            int point_y1 = 12;
            int point_y2 = 19;

            double lenght = Math.Sqrt((Math.Pow(point_x2 - point_x1, 2) + Math.Pow(point_y2 - point_y1, 2)));
            Console.WriteLine("Lenght {0:#.##}", lenght);
        }   
    }
}

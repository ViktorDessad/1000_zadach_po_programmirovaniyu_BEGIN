using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int point_x1 = 34, point_y1 = 24;
            int point_x2 = -45, point_y2 = 12;
            int point_x3 = 21, point_y3 = -1;

            double line_AB = Math.Sqrt(Math.Pow(point_x2 - point_x1, 2) + Math.Pow(point_y2 - point_y2, 2));
            double line_BC = Math.Sqrt(Math.Pow(point_x3 - point_x2, 2) + Math.Pow(point_y3 - point_y2, 2));
            double line_CA = Math.Sqrt(Math.Pow(point_x3 - point_x1, 2) + Math.Pow(point_y3 - point_y1, 2));

            double p = line_AB + line_BC + line_CA;
            //p /= 2;

            double triangleSquare = Math.Sqrt(p * (p - line_AB) + (p - line_BC) + (p - line_CA));

            Console.WriteLine("Triangle square is {0:#.##}", triangleSquare);
        }
    }
}

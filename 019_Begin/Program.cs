using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  (y)
             *  ************
             *  *          *
             *  *          *
             *  *          *
             *  *          *
             *  *          *
             *  ************ (x)
             */

            int point_X1 = 10;
            int point_X2 = 6;
            int point_Y1 = 15;
            int point_Y2 = 3;

            int line_X1_X2 = Math.Abs(point_X1 - point_X2);
            int line_Y1_Y2 = Math.Abs(point_Y1 - point_Y2);

            int perimeter = line_X1_X2 + line_Y1_Y2 * 2;
            int square = line_Y1_Y2 * line_X1_X2;

            Console.WriteLine("Perimeter {0}, square {1}", perimeter, square);
        }
    }
}

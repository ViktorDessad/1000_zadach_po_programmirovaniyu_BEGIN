using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент A");
            double coefficient_A = Convert.ToDouble(Console.ReadLine());

            if (coefficient_A != 0)
            {
                Console.WriteLine("Введите коэффициент В");
                double coefficient_B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите коэффициент C");
                double coefficient_C = Convert.ToDouble(Console.ReadLine());

                double D = Math.Pow(coefficient_B, 2) - (4 * coefficient_A * coefficient_C);
                D = Math.Abs(D);
                double x1 = (-coefficient_B - Math.Sqrt(D)) / (2 * coefficient_A);
                double x2 = (-coefficient_B + Math.Sqrt(D)) / (2 * coefficient_A);

                Console.WriteLine("х1 = {0}, x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("A !=0 ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент A");
            double coefficient_A = Convert.ToDouble(Console.ReadLine());

            if (coefficient_A !=0)
            {
                Console.WriteLine("Введите коэффициент В");
                double coefficient_B = Convert.ToDouble(Console.ReadLine());

                double the_equation = -coefficient_B / coefficient_A;
                Console.WriteLine("х = {0}", the_equation);
            }
            else
            {
                Console.WriteLine("A !=0 ");
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести первое число A: ");
            int number_A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввести второе число B: ");
            int number_B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввести третье число С: ");
            int number_C = Convert.ToInt32(Console.ReadLine());

            //int buffer_A = number_A;

            //number_A = number_B;
            //number_B = number_C;
            //number_C = buffer_A;

            //Console.WriteLine("The result is A = {0}, B = {1}, C = {2}", number_A, number_B, number_C);


            int sum_ABC = number_A + number_B + number_C;  //6
            int buf_A = number_A;

            number_A = sum_ABC - number_A - number_C;    //1  // 6-1-3 = 2
            number_B = sum_ABC - buf_A - number_A;       //2  // 6-1-2 = 3 
            number_C = sum_ABC - number_A - number_B;    //3  // 6-2-3 = 1 
            Console.WriteLine("The result is A = {0}, B = {1}, C = {2}", number_A, number_B, number_C);

        }
    }
}

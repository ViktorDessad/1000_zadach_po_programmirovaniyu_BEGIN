using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Begin
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

            int buffer_B = number_B;
            int buffer_A = number_A;

            number_A = number_C; //1 
            number_B = buffer_A; //2 
            number_C = buffer_B; //3 

            Console.WriteLine("The result is A = {0}, B = {1}, C = {2}", number_A, number_B, number_C); 
        }
    }
}

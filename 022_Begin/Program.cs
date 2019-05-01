using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ввести первое число A: ");
            int number_A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввести второе число B: ");
            int number_B = Convert.ToInt32(Console.ReadLine());


            //ПОМЕНЯТЬ ПЕРЕМЕННЫЕ МЕСТАМИ ЧЕРЕЗ БУФФЕР

            //int buffer_A = number_A;

            //number_A = number_B;
            //number_B = buffer_A; 
            //Console.WriteLine("Сейчас A = {0}, B = {1},",number_A, buffer_A);*/

            //ПОМЕНЯТЬ ПЕРЕМЕННЫЕ МЕСТАМИ ЧЕРЕЗ сложение/вычитание

            //int sum_AB = number_A + number_B; 
            //number_B = sum_AB - number_B;
            //number_A = sum_AB - number_B;
            //Console.WriteLine("Сейчас A = {0}, B = {1},", number_A, number_B);


            //ПОМЕНЯТЬ ПЕРЕМЕННЫЕ МЕСТАМИ ЧЕРЕЗ умножение/деление

            //int sum_AB = number_B * number_A;
            //number_B = sum_AB / number_B;
            //number_A = sum_AB / number_B;

            //Console.WriteLine("Сейчас A = {0}, B = {1}", number_A, number_B);







        }
    }
}

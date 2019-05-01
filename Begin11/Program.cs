using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = -50;
            int secondNumber = -25;

            double modFirstNumber = Math.Abs(firstNumber);
            double modSecondNumber = Math.Abs(secondNumber);

            double sum = modFirstNumber + modSecondNumber;
            double sub = modFirstNumber - modSecondNumber;
            double mul = modFirstNumber * modSecondNumber;
            double div = modFirstNumber / modSecondNumber;

            Console.WriteLine($"The result is Sum - {sum}, Sub - {sub}, Mul - {mul}, Div - {div}");
        }
    }
}

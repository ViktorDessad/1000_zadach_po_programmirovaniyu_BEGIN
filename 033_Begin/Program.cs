using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену конфет за 1 кг: ");
            double candyPricePerOneKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество конфет в кг: ");
            double candyQuantity = Convert.ToDouble(Console.ReadLine());

            double candyFullPrice = candyPricePerOneKg * candyQuantity;

            Console.WriteLine("Начальная цена конфет за 1 кг {0:C}, вы всего за {1} кг конфет заплатили {2:C}",
                candyPricePerOneKg,
                candyQuantity, 
                candyFullPrice);

        }
    }
}

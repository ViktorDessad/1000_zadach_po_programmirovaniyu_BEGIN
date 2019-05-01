using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество шоколадных конфет в кг: ");
            double candyChocolade = Convert.ToDouble(Console.ReadLine());
            double candyChocoladePrice = 2.45;

            double candyChocoladeQuantity = candyChocolade * candyChocoladePrice;

            Console.Write("Введите количество ирисок в кг: ");
            double candyToffee = Convert.ToDouble(Console.ReadLine());
            double candyToffePrice = 1.78;

            double candyToffeQuantity = candyToffee * candyToffePrice;

            Console.WriteLine("Вы купили {0} кг шоколадных конфет по цене в {1:C} за кг, " +
                "всего сумма {2:C} за {0} кг", 
                candyChocolade, candyChocoladePrice, candyChocoladeQuantity);

            Console.WriteLine("Вы купили {0} кг ирисок по цене в {1:C} за кг, " +
                "всего сумма {2:C} за {0} кг",
                candyToffee, candyToffePrice, candyToffeQuantity);

        }
    }
}

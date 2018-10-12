using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsShop;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxCount = 3;
            Car[] car = new Car[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine($"Введите название машины #{i+1}: ");

                car[i] = new Car();
                car[i].Name = Console.ReadLine();

                Console.WriteLine("Введите цвет : ");
                car[i].Color = Console.ReadLine();

                Console.WriteLine("Введите цену: ");

                double price;
                string priceIn = Console.ReadLine();
                if ( double.TryParse(priceIn, out price) )
                {
                    car[i].Price = price;
                }
            }

            Console.WriteLine("Ассортимент магазина:");

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine($"Название: {car[i].Name}\t Цвет: {car[i].Color}\t {car[i].Price}");
            }

            Console.Write("Получить скидку (1 - да; 2 - нет) ? ");

            int choose;
            string s = Console.ReadLine();
            int.TryParse(s, out choose);

            if (choose == 1) {

                Console.WriteLine("Введите название машины для скидки:");
                string carName = Console.ReadLine();

                for (int i = 0; i < car.Length; i++)
                {
                    if (car[i].Name == carName)
                    {
                        Console.WriteLine($"Ваша скидка {car[i].Sale}% - {car[i].GetSale()}");
                        break;
                    }
                    else if( i == car.Length - 1){
                        Console.WriteLine("Такой машины в ассортименте нет!");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

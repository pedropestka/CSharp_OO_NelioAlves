using System;
using System.Globalization;

namespace Aula70_vect_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] vect = new Product[3];

            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };

            }

            double sum = 0.0;

            for (int i = 0; i < 3; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / 3;

            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));






            Console.ReadLine();
        }
    }
}

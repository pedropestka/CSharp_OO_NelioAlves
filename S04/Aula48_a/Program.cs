using System;
using System.Globalization;

namespace Aula48_Ret_Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retangulo r;
            //r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo:");
            //r.L = double.Parse(Console.ReadLine());
            //r.H = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA: " + Retangulo.Area(l, a).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + Retangulo.Perimetro(l, a).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + Retangulo.Diagonal(l, a).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

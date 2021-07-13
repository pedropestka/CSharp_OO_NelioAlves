using System;
using System.Globalization;

namespace Aula48_Ret_Estatico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura do retangulo:");

            Retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA: " + Retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + Retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + Retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();           
            
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            r.L = double.Parse(Console.ReadLine());
            r.H = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

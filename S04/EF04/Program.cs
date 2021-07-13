using System;
using System.Globalization;

namespace EF_04_dolar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dolar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar: ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.DolarParaReal(cot, dol).ToString("F2", CultureInfo.InvariantCulture));




            Console.ReadLine();
        }
    }
}

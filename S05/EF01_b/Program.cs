using System;
using System.Globalization;

namespace EF_01_s05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;


            Console.Write("Entre o número da conta: ");
            string conta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string s = Console.ReadLine();

            if (s == "s")
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(nome, conta, deposito);
            }
            else
            {
                c = new ContaBancaria(nome, conta);
            }

            Console.WriteLine(c);

            Console.Write("Entre o valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(dep);
            Console.WriteLine(c);

            Console.Write("Entre o valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine(c);



            Console.ReadLine();
        }
    }
}

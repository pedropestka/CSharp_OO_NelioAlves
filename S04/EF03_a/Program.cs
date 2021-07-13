using System;
using System.Globalization;

namespace EF_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alex;
            alex = new Aluno();

            Console.Write("Nome do aluno: ");
            alex.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            alex.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alex.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alex.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(alex);
            if (alex.Resultado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double notaFaltante = 60.00 - alex.NotaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (notaFaltante.ToString("F2", CultureInfo.InvariantCulture)) + " PONTOS");
            }





            Console.ReadLine();
        }
    }
}

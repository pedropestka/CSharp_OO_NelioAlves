using System;
using System.Globalization;

namespace EF_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario js;
            js = new Funcionario();
            
            Console.Write("Nome: ");
            js.Nome = Console.ReadLine();
            
            Console.Write("Salário Bruto: ");
            js.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Imposto: ");
            js.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + js);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            js.AumentarSalario(aumento);
            Console.WriteLine("Dados Atualizados: " + js);

            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // entrada de n de empregados
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            // criaçao da lista
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");

                // entrada dos atributos do contrutor da classe empregado
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // adiciona o registro a lista
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            // entrada do id que se quer procurar
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            // percorre a lista para verificar o id digitado
            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                // altera o persentual
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                // id errado
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
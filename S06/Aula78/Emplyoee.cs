using System.Globalization;

namespace Course
{
    class Employee
    {

        // atributos da classe
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // construtor da classe
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // método para aumentar salário
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }


        //to string
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
using System;

namespace Aula72_params
{
    class Program
    {
        static void Main(string[] args)
        {
            //sem params
            //int s1 = Calculator.Sum(new int[] { 2, 3 });
            //int s2 = Calculator.Sum(new int[] { 2, 3, 4 });

            // com params
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}

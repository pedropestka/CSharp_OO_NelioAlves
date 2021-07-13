using System;

namespace Aula73_Mod_out
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);



            Console.ReadLine();
        }
    }
}

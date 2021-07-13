using System;

namespace Aula73_Mod_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            //********sem ref********

            //int a = 10;
            //Calculator.Triple(a);
            //Console.WriteLine(a);
            // erro - imprime 10


            //********com ref********

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            //imprime 30


            Console.ReadLine();
        }
    }
}

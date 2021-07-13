using System;

namespace Aula80_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            // entrada dos valores na matriz
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] svet = s.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(svet[j]);
                }
            }

            // imprimir a diagonal principal
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();

            // imprimir negativos
            int contneg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        contneg ++;
                        //Console.Write(mat[i, j]);
                    }
                }
            }
            Console.WriteLine(contneg);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula48_Ret_Estatico2
{
    class Retangulo
    {
        public static double Largura;
        public static double Altura;

        public static double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public static double Perimetro()
        {
            double perimetro = 2 * Largura + 2 * Altura;
            return perimetro;
        }

        public static double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }

    }
}

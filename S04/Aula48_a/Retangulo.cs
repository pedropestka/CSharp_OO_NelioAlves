using System;
using System.Collections.Generic;
using System.Text;

namespace Aula48_Ret_Estatico
{
    class Retangulo
    {
        //public double L;
        //public double H;

        public static double Area(double Largura, double Altura)
        {
            double area = Largura * Altura;
            return area;
        }

        public static double Perimetro(double Largura, double Altura)
        {
            double perimetro = 2 * Largura + 2 * Altura;
            return perimetro;
        }

        public static double Diagonal(double Largura, double Altura)
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }

    }
}

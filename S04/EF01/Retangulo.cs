using System;
using System.Collections.Generic;
using System.Text;

namespace EF_01
{
    class Retangulo
    {
        public double L;
        public double H;

        public double Area()
        {
            double area = L * H;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * L + 2 * H;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(L, 2) + Math.Pow(H, 2));
            return diagonal;
        }

    }
}

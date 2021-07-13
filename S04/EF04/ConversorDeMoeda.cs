using System;
using System.Collections.Generic;
using System.Text;

namespace EF_04_dolar
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacao, double dolar)
        {
            double valoreEmReais = cotacao * dolar * (1 + IOF / 100.00);
            return valoreEmReais;
        }



    }
}

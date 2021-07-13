using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_03
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            double nf = Nota1 + Nota2 + Nota3;
            return nf;
        }

        public bool Resultado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL = "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

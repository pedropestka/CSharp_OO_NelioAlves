using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EF_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public double SalarioLiquido()
        {
            double liquido = SalarioBruto - Imposto;
            return liquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1 + porcentagem/100.00);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

using System.Globalization;

namespace EF_01_s05
{
    class ContaBancaria
    {
        private string _nome;
        private string _conta;
        private double _saldo;

        //****************CONSTRUTORES*****************

        // construtor para o caso de depósito inicial
        public ContaBancaria(string nomeTitular, string conta, double saldo)
        {
            _nome = nomeTitular;
            _conta = conta;
            _saldo = saldo;
        }

        //construtor para o caso se nao haver depósito inicial
        public ContaBancaria(string nomeTitular, string conta)
        {
            _nome = nomeTitular;
            _conta = conta;
            _saldo = 0.00;
        }

        //****************GETTERS AND SETTERS**********
        //nestes casos não são métodos - não vai '()'
        //utilizamos a palavra 'value' para definir o valor que recebe do programa


        // Get Set - NOME
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        // Get - SALDO
        public double Saldo
        {
            get { return _saldo; }
        }

        // Get - NÚMERO DA CONTA
        public string Conta
        {
            get { return _conta; }
        }

        //****************MÉTODOS*********************

        // Depósito - alterando o saldo
        public void Deposito(double deposito)
        {
            _saldo += deposito;
        }

        // Saque - alterando o saldo
        public void Saque(double saque)
        {
            _saldo -= (saque + 5.00);
        }

        //***************TO STRING********************

        public override string ToString()
        {
            return
                "\nDados da conta:\n"
                + "Conta "
                + _conta
                + ", Titular: "
                + _nome
                + ", Saldo: $ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

    }
}

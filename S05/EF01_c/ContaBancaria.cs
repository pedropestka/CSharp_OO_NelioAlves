using System.Globalization;

namespace EF_01_s05
{
    class ContaBancaria
    {
        private string _nome;
        public string Conta { get; private set; }
        public double Saldo { get; private set; }
        // no caso de autoproperties - os atributos são publicos
        // e os modificadores são colocadas no get e set
        // não se usa mais '_'  antes do nome do atributo, mas com letra maiuscula

        //****************CONSTRUTORES*****************

        // construtor para o caso de depósito inicial
        public ContaBancaria(string nomeTitular, string conta, double saldo)
        {
            _nome = nomeTitular;
            Conta = conta;
            Saldo = saldo;
        }

        //construtor para o caso se nao haver depósito inicial
        public ContaBancaria(string nomeTitular, string conta)
        {
            _nome = nomeTitular;
            Conta = conta;
            Saldo = 0.00;
        }

        //****************GETTERS AND SETTERS**********
        //nestes casos não são métodos - não vai '()'
        //utilizamos a palavra 'value' para definir o valor que recebe do programa
        // Get Set - NOME
        // com regra de entrada de dados
        // mantem o campo como private
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 3)
                {
                    _nome = value;
                }
            }
        }

        //****************MÉTODOS*********************

        // Depósito - alterando o saldo
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        // Saque - alterando o saldo
        public void Saque(double saque)
        {
            Saldo -= (saque + 5.00);
        }

        //***************TO STRING********************

        public override string ToString()
        {
            return
                "\nDados da conta:\n"
                + "Conta "
                + Conta
                + ", Titular: "
                + _nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

    }
}

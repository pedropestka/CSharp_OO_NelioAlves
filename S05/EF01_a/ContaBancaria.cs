namespace EF_01_s05
{
    class ContaBancaria
    {
        private string _nome;
        private string _conta;
        private double _saldo;

        //****************CONSTRUTORES**********************

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

        //****************GETTERS AND SETTERS***********

        // Obter Nome
        public string GetNome()
        {
            return _nome;
        }

        // Definir Nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //Obter Saldo
        public double GetSaldo()
        {
            return _saldo;
        }

        //Obter numero da conta
        public string GetNConta()
        {
            return _conta;
        }

        //****************MÉTODOS**********************

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
    }
}

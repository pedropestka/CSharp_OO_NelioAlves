using Heranca1.Entities;
using System;

namespace Heranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");



                Console.ReadLine();
            }
        }
    }
}



/*
 * herança - inheritance
 * protected
 * base
 * upcasting
 * downcasting
 * is
 * as
 * 
 * Curso C# Completo - Prof Nelio Alves - vídeos 126 e 127
 * 
 * Herança permite o reuso de atributos e métodos (dados e comportamento)
 * 
 * COMPOSICAO --->>> relacao tem-um >>> tem-varios
 * HERANCA    --->>> relaçao é-um
 *  
 * 
 * SUPERCLASSE / classe base / 'generica' >>> Account
 * SUBCLASSE / classe derivada / 'especializada' >>> BusinessAccount
 * 
 * 
 * 
 * Upcasting
 * • Casting da subclasse para superclasse
 * • Uso comum: polimorfismo
 * 
 * Downcasting
 * • Casting da superclasse para subclasse
 * • Palavra as
 * • Palavra is
 * • Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)
 * 
 * 
 */

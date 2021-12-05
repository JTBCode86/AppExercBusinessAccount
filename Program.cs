using System;
using AppExercBusinessAccount.Entities;

namespace AppExercBusinessAccount
{
    /// <summary>
    /// Exercicio - POO: Herança e Polimorfismo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Braian Lemos", 100.00,500);
            //Console.WriteLine(account.Balance);
            //Console.ReadLine();

            Account acc = new Account(1001, "Aline", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Sabrina", 0.0, 500);

            //UpCasting...
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Sarah", 0.0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DownCasting (Obs: Operação insegura)
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //Erro por conta do casting... (Erro pego em tempo de excecução)
            //BusinessAccount acc5 = (BusinessAccount)acc3; 
            
            //Testar antes de converter...
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;

                //Referencia de como fazer o casting também...
                //BusinessAccount acc5 = acc3 as BusinessAccount;
                
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                //Referencia de como fazer o casting também...
                //SavingsAccount acc5 = acc3 as SavingsAccount;

                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            Console.ReadLine();
            
        }
    }
}

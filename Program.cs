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
            BusinessAccount account = new BusinessAccount(8010, "Braian Lemos", 100.00,500);
            Console.WriteLine(account.Balance);
            Console.ReadLine();
        }
    }
}

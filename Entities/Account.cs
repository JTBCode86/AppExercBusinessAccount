using System;
namespace AppExercBusinessAccount.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public void WithDraw(double amount) 
        {
            Balance -= amount;
        }

        public void Deposit(double amount) 
        {
            Balance += amount;
        }
    }
}

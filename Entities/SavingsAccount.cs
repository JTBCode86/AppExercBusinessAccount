namespace AppExercBusinessAccount.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number,holder,balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance() 
        {
            Balance += Balance * InterestRate;
        }
    }
}

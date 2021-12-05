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

        //Evitando que o metodo seja herdado (Está selada "sealed")
        public sealed override void WithDraw(double amount)
        {
            //Usando a palavra base. Uso a regra da classe base e implemento também um nova regra:
            //Desconto de 2.0
            base.WithDraw(amount); 
            Balance -= 2.0;
        }
    }
}

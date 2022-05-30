namespace ITMO.CSharp.Lab08.Constructors {
    class BankAccount {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        public void TransferFrom(BankAccount accFrom, decimal amount) {
            if(accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
        public BankAccount() {
            accNo = BankAccount.NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
        }
        public BankAccount(AccountType aType) {
            accNo = BankAccount.NextNumber();
            accBal = 0;
            accType = aType;
        }
        public BankAccount(decimal aBal) {
            accNo = BankAccount.NextNumber();
            accBal = aBal;
            accType = AccountType.Checking;
        }
        public BankAccount(AccountType aType, decimal aBal) {
            accNo = BankAccount.NextNumber();
            accBal = aBal;
            accType = aType;
        }
        public long Number() {
            return accNo;
        }
        public decimal Balance() {
            return accBal;
        }
        public string Type() {
            return accType.ToString();
        }
        private static long NextNumber() {
            return nextAccNo++;
        }
        public decimal Deposit(decimal amount) {
            accBal += amount;
            return accBal;
        }
        public bool Withdraw(decimal amount) {
            bool sufficientFunds = accBal >= amount;
            if(sufficientFunds) {
                accBal -= amount;
            }
            return sufficientFunds;
        }
    }
}

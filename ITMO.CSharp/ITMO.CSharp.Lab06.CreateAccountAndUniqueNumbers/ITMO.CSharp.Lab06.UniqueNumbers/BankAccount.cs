namespace ITMO.CSharp.Lab06.UniqueNumbers {
    class BankAccount {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        public void Populate(decimal balance) {
            accNo = BankAccount.NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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
    }
}
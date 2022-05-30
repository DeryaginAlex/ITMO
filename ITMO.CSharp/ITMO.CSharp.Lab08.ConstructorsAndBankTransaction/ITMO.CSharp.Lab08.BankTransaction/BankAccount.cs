using System.Collections;

namespace ITMO.CSharp.Lab08.BankTransaction {
    class BankAccount {
        private Queue tranQueue = new Queue();
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        public Queue Transactions() {
            return tranQueue;
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
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }
        public bool Withdraw(decimal amount) {
            bool sufficientFunds = accBal >= amount;
            if(sufficientFunds) {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }
    }
}

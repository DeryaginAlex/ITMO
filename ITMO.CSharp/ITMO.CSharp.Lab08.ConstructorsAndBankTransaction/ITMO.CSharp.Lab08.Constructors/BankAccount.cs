using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ITMO.CSharp.Lab08.Constructors {
    class BankAccount {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        public void TransferFrom(BankAccount accFrom, decimal amount) {
            if(accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
        //public void Populate(decimal balance)
        //{
        //    accNo = BankAccount.NextNumber();
        //    accBal = balance;
        //    accType = AccountType.Checking;
        //}
        //Add constructors BankAccount(), BankAccount(AccountType aType),
        //BankAccount(decimal aBal), BankAccount(AccountType aType, decimal aBal),
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
        //End of adding constructors
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

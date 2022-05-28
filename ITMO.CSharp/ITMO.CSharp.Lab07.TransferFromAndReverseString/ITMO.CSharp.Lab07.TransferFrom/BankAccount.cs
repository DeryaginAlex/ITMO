using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab07TransferFrom {
    class BankAccount {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public void TransferFrom(BankAccount accFrom, decimal amount) {
            if(accFrom.Withdraw(amount))
                this.Deposit(amount);
        }

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

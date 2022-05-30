using System;

namespace ITMO.CSharp.Lab08.BankTransaction {
    internal class CreateAccount {
        static void Main() {
            BankAccount acc1 = new BankAccount();
            Write(acc1);
            TestDeposit(acc1);
            Write(acc1);
            TestWithdraw(acc1);
            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            Write(acc2);
            TestDeposit(acc2);
            Write(acc2);
            TestWithdraw(acc2);
            Write(acc2);
            BankAccount acc3 = new BankAccount(100);
            Write(acc3);
            TestDeposit(acc3);
            Write(acc3);
            TestWithdraw(acc3);
            Write(acc3);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);
            Write(acc4);
            TestDeposit(acc4);
            Write(acc4);
            TestWithdraw(acc4);
            Write(acc4);
        }
        public static void TestDeposit(BankAccount acc) {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        public static void TestWithdraw(BankAccount acc) {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if(!acc.Withdraw(amount)) {
                Console.WriteLine("Insufficient funds.");
            }
        }
        static void Write(BankAccount acc) {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach(BankTransaction tran in acc.Transactions()) {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
    }
}

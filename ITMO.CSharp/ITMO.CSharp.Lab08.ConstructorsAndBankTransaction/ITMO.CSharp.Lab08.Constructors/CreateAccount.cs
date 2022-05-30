using System;

namespace ITMO.CSharp.Lab08.Constructors {
    class CreateAccount {
        static void Main() {
            BankAccount acc1, acc2, acc3, acc4;
            acc1 = new BankAccount();
            acc2 = new BankAccount(AccountType.Deposit);
            acc3 = new BankAccount(100);
            acc4 = new BankAccount(AccountType.Deposit, 500);
            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
            void Write(BankAccount toWrite) {
                Console.WriteLine("Account number is {0}", toWrite.Number());
                Console.WriteLine("Account balance is {0}", toWrite.Balance());
                Console.WriteLine("Account type is {0}", toWrite.Type());
            }
        }
    }
}

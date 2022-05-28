using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ITMO.CSharp.Lab08.Constructors {
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
            //static void Main()
            //{
            //    BankAccount berts = NewBankAccount();
            //    Write(berts);
            //    TestDeposit(berts);
            //    Write(berts);
            //    TestWithdraw(berts);
            //    Write(berts);

            //    BankAccount freds = NewBankAccount();
            //    Write(freds);
            //    TestDeposit(freds);
            //    Write(freds);
            //    TestWithdraw(freds);
            //    Write(freds);
            //}

            //static BankAccount NewBankAccount()
            //{
            //    BankAccount created = new BankAccount();

            //    Console.Write("Enter the account balance! : ");
            //    decimal balance = decimal.Parse(Console.ReadLine());

            //    created.Populate(balance);

            //    return created;
            //}

            //public static void TestDeposit(BankAccount acc)
            //{
            //    Console.Write("Enter amount to deposit: ");
            //    decimal amount = decimal.Parse(Console.ReadLine());
            //    acc.Deposit(amount);
            //}

            //public static void TestWithdraw(BankAccount acc)
            //{
            //    Console.Write("Enter amount to withdraw: ");
            //    decimal amount = decimal.Parse(Console.ReadLine());
            //    if (!acc.Withdraw(amount))
            //    {
            //        Console.WriteLine("Insufficient funds.");
            //    }
            //}
            void Write(BankAccount toWrite) {
                Console.WriteLine("Account number is {0}", toWrite.Number());
                Console.WriteLine("Account balance is {0}", toWrite.Balance());
                Console.WriteLine("Account type is {0}", toWrite.Type());
            }
        }
    }
}

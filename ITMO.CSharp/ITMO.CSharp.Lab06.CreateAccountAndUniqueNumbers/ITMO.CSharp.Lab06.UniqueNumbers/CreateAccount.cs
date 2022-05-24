﻿using System;
class CreateAccount {
    static void Main() {
        BankAccount berts = NewBankAccount();
        Write(berts);

        BankAccount freds = NewBankAccount();
        Write(freds);
    }

    static BankAccount NewBankAccount() {
        BankAccount created = new BankAccount();

        //long number = BankAccount.NextNumber();

        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());

        created.Populate(balance);

        return created;
    }

    static void Write(BankAccount toWrite) {
        Console.WriteLine("Account number is {0}", toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }
}
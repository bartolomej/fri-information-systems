using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Marko");

            account.Deposit(10, "First deposit");
            System.Console.WriteLine(account);
            account.Withdraw(5, "First withdraw");
            System.Console.WriteLine(account);
            account.Withdraw(6, "Second withdraw"); // this throws an exception
        }
    }
}

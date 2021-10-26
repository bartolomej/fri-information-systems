using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccount
    {

        private List<Transaction> allTransactions = new List<Transaction>();
        public int Id { get; set; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
        public decimal TotalTransactions
        {
            get
            {
                return this.allTransactions.Count;
            }
        }
        public BankAccount(string name)
        {
            var random = new Random();
            this.Id = random.Next();
            this.Owner = name;
        }
        public void Deposit(decimal amount, string note)
        {
            this.allTransactions.Add(new Transaction(amount, note));
        }
        public void Withdraw(decimal amount, string note)
        {
            if (this.Balance - amount <= 0)
            {
                throw new Exception("Balance too low.");
            }
            this.allTransactions.Add(new Transaction(-amount, note));
        }
        override public string ToString()
        {
            return $"Account(id={this.Id}, owner={this.Owner}, balance={this.Balance}, txCount={this.TotalTransactions})";
        }
    }
}
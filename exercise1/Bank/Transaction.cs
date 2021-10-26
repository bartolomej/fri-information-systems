using System;

namespace Bank 
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime DateTime { get; }
        public string Note { get; }

        public Transaction(decimal amount, string note) {
            this.Amount = amount;
            this.DateTime = new DateTime();
            this.Note = note;
        }
    }

}
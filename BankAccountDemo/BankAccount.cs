using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class BankAccount
    {
        // creating variables needed
        private string accountId;
        private string customerName;
        private decimal balance;
        private List<string> transactions;

        // Constructor -- empty for now
        public BankAccount(string customerName, decimal initialBalance)
        {
            // geneating account ID by randomizing it, customername, balance..
            this.accountId = "ACC" + new Random().Next(10000, 99999);
            this.customerName = customerName;
            this.balance = initialBalance;
            this.transactions = new List<string>();

            // recording initial transaction
            this.transactions.Add($"Initial deposit: ${initialBalance}");
        }

        // Properties
        public string AccountId
        {
            get { return accountId; }
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public List<string> Transactions
        {
            get { return transactions; }
        }

        // Deposit method
        public bool Deposit(decimal amount)
        {
            // error checking
            if (amount <= 0)
            {
                return false;
            }

            // updating balance and adding to transaction history:
            balance += amount;
            transactions.Add($"Deposit: ${amount}");
            return true;
        }

        // Withdraw method
        public bool Withdraw(decimal amount)
        {
            // error checking
            if (amount <= 0)
            {
                return false;
            }
            // checking for enough money
            if (amount > balance)
            {
                return false;
            }

            // updating balance and adding to transaction history:
            balance -= amount;
            transactions.Add($"Withdrawal: ${amount}");
            return true;
        }

    }
}

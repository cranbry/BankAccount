using BankAccount;

BankAccount.BankAccount ba = new BankAccount.BankAccount("Mouad", 1000);

ba.Deposit(40);

Console.WriteLine(ba.CustomerName + " has a balance of " + ba.Balance);
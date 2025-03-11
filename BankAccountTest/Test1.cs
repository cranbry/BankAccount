using BankAccount;

namespace BankAccountTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestInitialBalance()
    {
        var account = new BankAccount.BankAccount("Marcus", 100);
        var balance = account.Balance;
        Assert.AreEqual(100, balance);
    }

    [TestMethod]
    public void TestDeposit()
    {
        BankAccount.BankAccount ba = new BankAccount.BankAccount("Marcus", 100);
        int depositAmount = 40;
        ba.deposit(depositAmount);

        Assert.AreEqual(140, ba.Balance);

    }
    [TestMethod]
    public void TestAccountHolder()
    {
        BankAccount.BankAccount ba = new BankAccount.BankAccount("Marcus", 100);
        Assert.AreEqual("Marcus", ba.AccountHolder);
    }
    [TestMethod]
    public void TestWithdrawal()
    {
        BankAccount.BankAccount ba = new BankAccount.BankAccount("Marcus", 100);
        ba.withdraw(30);

        Assert.AreEqual(70, ba.Balance);
    }
    [TestMethod]
    public void TestNegativeInitialBalance()
    {
        BankAccount.BankAccount ba = new BankAccount.BankAccount("Marcus", -50);
        Assert.IsTrue(ba.Balance >= 0, "Balance should not be negative");
    }
    [TestMethod]
    public void TestOverdraftProtection()
    {
        BankAccount.BankAccount ba = new BankAccount.BankAccount("Marcus", 50);
        ba.withdraw(100);

        Assert.IsTrue(ba.Balance > 0, "Overdraft protection should prevent negative balance");

    }
}
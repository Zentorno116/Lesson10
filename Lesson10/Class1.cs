using System;
using System.Collections;
using System.Collections.Generic;

public enum AccountType
{
    Checking,
    Savings,
    Deposit
}

public class BankTransaction
{
    public readonly decimal Amount;
    public readonly DateTime TransactionDate;

    public BankTransaction(decimal amount)
    {
        Amount = amount;
        TransactionDate = DateTime.Now;
    }
}

public class BankAccount
{
    internal string accountNumber;
    internal decimal balance;
    internal AccountType accountType;
    internal Queue transactions;

    internal BankAccount()
    {
        GenerateAccountNumber();
        transactions = new Queue();
    }

    internal BankAccount(decimal balance) : this()
    {
        Deposit(balance);
    }

    internal BankAccount(AccountType accountType) : this()
    {
        this.accountType = accountType;
    }

    internal BankAccount(decimal balance, AccountType accountType) : this(accountType)
    {
        Deposit(balance);
    }

    private void GenerateAccountNumber()
    {
        this.accountNumber = Guid.NewGuid().ToString("N").Substring(0, 12);
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public decimal Balance
    {
        get { return balance; }
    }

    public AccountType Type
    {
        get { return accountType; }
        set { accountType = value; }
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        transactions.Enqueue(new BankTransaction(amount));
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
        transactions.Enqueue(new BankTransaction(-amount));
    }
}

public class BankAccountFactory
{
    private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

    public string CreateAccount()
    {
        var account = new BankAccount();
        accounts.Add(account.AccountNumber, account);
        return account.AccountNumber;
    }

    public string CreateAccount(decimal balance)
    {
        var account = new BankAccount(balance);
        accounts.Add(account.AccountNumber, account);
        return account.AccountNumber;
    }

    public string CreateAccount(AccountType accountType)
    {
        var account = new BankAccount(accountType);
        accounts.Add(account.AccountNumber, account);
        return account.AccountNumber;
    }

    public string CreateAccount(decimal balance, AccountType accountType)
    {
        var account = new BankAccount(balance, accountType);
        accounts.Add(account.AccountNumber, account);
        return account.AccountNumber;
    }

    public void CloseAccount(string accountNumber)
    {
        accounts.Remove(accountNumber);
    }

    public BankAccount GetAccount(string accountNumber)
    {
        return accounts[accountNumber];
    }
}

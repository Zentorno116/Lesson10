using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 11.1.Банк с BankTransaction(edit). ");
        BankAccountFactory factory = new BankAccountFactory();
        string accountNumber = factory.CreateAccount(10112023m, AccountType.Savings);
        BankAccount account = factory.GetAccount(accountNumber);

        Console.WriteLine($"Номер счета: {account.AccountNumber}");
        Console.WriteLine($"Баланс: {account.Balance}");
        Console.WriteLine($"Тип счета: {account.Type}");
    }
}

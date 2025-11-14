// Encapsulation Example: BadBankAccount.cs

using DesignPatterns.src.OopPrinciples.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 1000m; // Direct access to the Balance field
Console.WriteLine($"Bad Account Balance: {badAccount.balance}");

BankAccount goodAccount = new BankAccount(1000m);
goodAccount.Deposit(500m);
goodAccount.Withdraw(200m);
Console.WriteLine($"Good Account Balance: {goodAccount.GetBalance()}");
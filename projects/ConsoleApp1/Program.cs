using Classes;

var account = new BankAccount("Elon",10000);
account.MakeWithdrawal(100, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}
// Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}
account.MakeDeposit(500, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());
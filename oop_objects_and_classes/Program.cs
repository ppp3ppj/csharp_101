// See https://aka.ms/new-console-template for more information
using System;
namespace MySuperBank {
  class Program {
    static void Main(string[] args) {
      var account = new BankAccount("ppp", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
      account.MakeWithdrawal(120, DateTime.Now, "Hammock");
      Console.WriteLine(account.Balance);


          account.MakeDeposit(50, DateTime.Now, "Xbox Game");
      Console.WriteLine(account.Balance);

      Console.WriteLine(account.GetAccountHistory());

    }
  }
}

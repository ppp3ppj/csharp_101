﻿// See https://aka.ms/new-console-template for more information
using System;
namespace MySuperBank {
  class Program {
    static void Main(string[] args) {
      var account = new BankAccount("ppp", 1000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
    }
  }
}

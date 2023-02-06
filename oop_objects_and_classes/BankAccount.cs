using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank {
  public class BankAccount {
    public string Number { get; }
    public string Owner {get; set;}
    public decimal Balance {
      get {
        decimal balace = 0;
        foreach(var item in allTransactions) {
          balace += item.Amount;
        }
        return balace;
      }
    }

    private static int accountNumberSeed = 1234567890;

    private List<Transaction> allTransactions = new List<Transaction>();

    public BankAccount(string name, decimal initialBalance) {
      this.Owner = name;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note) {

    }
    public void MakeWithdrawal(decimal amount, DateTime date, string note) {

    }

  }
}

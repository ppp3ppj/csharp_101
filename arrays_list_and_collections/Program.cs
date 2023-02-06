// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ConsoleApp6 {
  class Program {
    static void Main(string[] args) {
      var names = new List<string> {"<name>", "Scott", "Kendra"};
      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Scott");
      foreach(var name in names) {
        Console.WriteLine(name);
      }

      Console.WriteLine(names[0]);
      Console.WriteLine(names[1]);
      /*
      foreach(var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      for(int i = 0; i < names.Count; i++) {
        Console.WriteLine($"Hello {names[i].ToUpper()}!");
      }
      */
    }
  }
}

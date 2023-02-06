// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ConsoleApp6 {
  class Program {
    static void Main(string[] args) {
      var names = new List<string> {"<name>", "Ana", "Felipe"};
      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Scott");
      foreach(var name in names) {
        Console.WriteLine(name);
      }

      Console.WriteLine($"My name is {names[0]}");
      Console.WriteLine($"My name is {names[2]} and {names[3]} to the list");

      Console.WriteLine($"The list has {names.Count} people in it");


      var index = names.IndexOf("Felipe");
      Console.WriteLine($"The name {names[index]} is at index {index}");

      var notFound = names.IndexOf("Not Found");
      Console.WriteLine($"When an item is not found, Index of returns {notFound}");
      /*
      if(index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      } else {
        Console.WriteLine($"The name {names[index]} is at {index}");
      }
      */
      names.Sort();
      foreach(var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}

// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp6 {
  class Program {
    static void Main(string[] args) {
      int a = 5;
      int b = 3;
      int c = 4;
      bool something = (a + b + c > 10) || (a == b);
      if(something) {
        Console.WriteLine("The answer is greater than 10.");
        Console.WriteLine("Add the first number is equal to the second");
      }
      else {
        Console.WriteLine("The answer is not greater then 10");
        Console.WriteLine("The first number is not equal to the second");
      }
    }
  }
}

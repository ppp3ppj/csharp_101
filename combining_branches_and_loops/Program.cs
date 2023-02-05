// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp6 {
  class Program {
    static void Main(string[] args) {
      int sum = 0;
      for(int i = 0; i <= 20; i++) {
        if(i % 3 == 0) {
          sum += i;
        }
      }
      Console.WriteLine($"Result is {sum}");
    }
  }
}

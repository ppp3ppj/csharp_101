// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp6 {
  class Program {
    static void Main(string[] args) {
      int counter = 0;
      int while_counter = 0;
      while(while_counter < 10) {
        Console.WriteLine($"The while counter is {while_counter}");
        while_counter++;
      }
     for(int index = 0; index < 10; index++) {
       Console.WriteLine($"Hello World! The index is {index}");
     }

      do {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
      } while(counter < 10);

    }
  }
}

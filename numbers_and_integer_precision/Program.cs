// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numbers and Integer Precision");
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// min and max
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// underflow and overflow
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Double Single Precision and Double Precision
double f = 5;
double g = 4;
double h = 2;
double i = (f + g) / h;
Console.WriteLine(i);

// Double min and max
double max_double = double.MaxValue;
double min_double = double.MinValue;
Console.WriteLine($"The range of double is {min_double} to {max_double}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

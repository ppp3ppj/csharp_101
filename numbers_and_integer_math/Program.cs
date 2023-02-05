// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numbers and Integer Match");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine($"Result a + b is {c}");
c = a * b;
Console.WriteLine($"Result a * b is {c}");
c = a / b;
Console.WriteLine($"Result a / b is {c}");

// Order of Operations
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);
// or
d = (a + b) * c;
Console.WriteLine(d);

// many diff operations
d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

// Integer Division always interger result not float or double
a  = 7;
b = 4;
c = 3;
d = (a + b) / c;
Console.WriteLine(d);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numbers and Decimals");

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} ot {max}");

int min2 = int.MinValue;
int max2 = int.MaxValue;
Console.WriteLine($"The range of the int type is {min2} ot {max2}");

long min3 = long.MinValue;
long max3 = long.MaxValue;
Console.WriteLine($"The range of the long type is {min3} ot {max3}");

short min4 = short.MinValue;
short max4 = short.MaxValue;
Console.WriteLine($"The range of the long type is {min4} ot {max4}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

// Challenge
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

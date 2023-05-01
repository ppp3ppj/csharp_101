partial class Program
{
    delegate string MyDelegate(string _firstname, string _lastname);

    delegate void CalculatorDelegate(int a, int b);

    delegate double ArrayDelegate(int[] n);

    static void Add(int a, int b)
    {
        Console.WriteLine(a + " + " + b + " = " + (a+b)); 
    }
    static void Sub(int a, int b)
    {
        Console.WriteLine(a + " - " + b + " = " + (a-b)); 
    }
    static void Mul(int a, int b)
    {
        Console.WriteLine(a + " * " + b + " = " + (a*b)); 
    }

    static double Min(int[] n)
    {
        int min = n[0];
        for(int i = 1; i < n.Length; i++)
        {
            if (n[i] < min)
                min = n[i];
        }
        return min;
    }
    static double Max(int[] n)
    {
        int max = n[0];
        for(int i = 1; i < n.Length; i++)
        {
            if (n[i] > max)
                max = n[i];
        }
        return max;
    }
    /*
    static string Callback1(string _firstname, string _lastname) {
        return string.Format($"Callback Call1 {_firstname}, {_lastname}");
    }
    static string Callback2(string _country, string _post) {
        return string.Format($"Callback Call2 {_country} {_post}");
    }
    */

    static void Main(string[] args)
    {
        CalculatorDelegate de = Add;
        de += Sub;
        de += Mul;
        de(10, 2);

        Console.WriteLine("-----------------------------------");
        de -= Add;
        de(20, 5);

        int[] number = { 1, 5, -1, 15, 55, 9, -5 };
        ArrayDelegate[] arrayDe = { Min, Max };
        const int SIZE = 2;
        double[] resultArr = new double[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            resultArr[i] = arrayDe[i](number);
        }
        Console.WriteLine("Min: {0}", resultArr[0]);
        Console.WriteLine("Max: {0}", resultArr[1]);
        /*
        MyDelegate de = new MyDelegate(Callback1);
        string result = de("PPP", "HIii");
        Console.WriteLine(result);
        de = Callback2;
        result = de("Bangkok", "52130");

        Console.WriteLine(result);
        */
    }

}


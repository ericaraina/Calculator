using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        //somma
        int sum = Calculator.Sum(a, b);

        Console.WriteLine("{0} + {1} = {2}", a, b, sum);
    }
}

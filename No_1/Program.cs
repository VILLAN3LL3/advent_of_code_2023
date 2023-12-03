using System;

namespace No_1;

class Program
{
    static void Main(string[] args)
    {
        var inputLoader = new InputLoader();
        var input = inputLoader.LoadInput();
        var calculator = new Calculator();
        var result = calculator.Calculate(input);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

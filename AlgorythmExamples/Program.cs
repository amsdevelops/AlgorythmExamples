using System;

class Program
{
    static void Main(string[] args)
    {
        var fibonacciSum = Fibonacci.FibonacciIterative(7);
        Console.WriteLine(fibonacciSum);
        Console.ReadLine();
    }
}

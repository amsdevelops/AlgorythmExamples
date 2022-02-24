using System;

class Fibonacci
{
    private static long sum;
    public static long FibonacciRecursion(long N)
    {
        if (N <= 1)
        {
            return 0;
        }
        if (N <= 2)
        {
            return 1;
        }
        else
        {
            return FibonacciRecursion(N - 1) + FibonacciRecursion(N - 2);
        }
    }

    public static long FibonacciIterative(long N)
    {
        long num0 = 0;
        long num1 = 1;
        long num2 = 0;

        for (int i = 0; i < N; i++)
        {
            num2 = num0 + num1;
            num0 = num1;
            num1 = num2;
        }

        return num2;
    }
}

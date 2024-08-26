using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci using Loops:");
        FibonacciLoop(10);

        Console.WriteLine("\nFibonacci using Recursion:");
        Console.WriteLine(0);
        Console.WriteLine(1);
        FibonacciRecursive(1, 0, 10);
    }

    static void FibonacciLoop(int n)
    {
        int prev2 = 0;
        int prev1 = 1;

        Console.WriteLine(prev2);
        Console.WriteLine(prev1);

        for (int i = 2; i < n; i++)
        {
            int newFibo = prev1 + prev2;
            Console.WriteLine(newFibo);
            prev2 = prev1;
            prev1 = newFibo;
        }
    }

    static void FibonacciRecursive(int prev1, int prev2, int n, int count = 2)
    {
        if (count < n)
        {
            int newFibo = prev1 + prev2;
            Console.WriteLine(newFibo);
            FibonacciRecursive(prev1 + prev2, prev1, n, count + 1);
        }
    }
}

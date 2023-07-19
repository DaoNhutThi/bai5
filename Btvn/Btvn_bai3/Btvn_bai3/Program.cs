using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số phần tử của dãy Fibonacci: ");
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine("Dãy Fibonacci gồm {0} phần tử:", count);
        for (int i = 0; i < count; i++)
        {
            long fibonacciNumber = Fibonacci(i);
            Console.Write(fibonacciNumber + " ");
        }
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        long previous = 0;
        long current = 1;
        long fibonacciNumber = 0;

        for (int i = 2; i <= n; i++)
        {
            fibonacciNumber = previous + current;
            previous = current;
            current = fibonacciNumber;
        }

        return fibonacciNumber;
    }
}

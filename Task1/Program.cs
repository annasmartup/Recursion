using System;

class Program
{

    static void GetDigitSequence(int m, int n)
    {
        if (m > n)
        {
            return;
        }
        GetDigitSequence(m, n - 1);
        Console.Write(n + ",");

    }
    static void Main(string[] args)
    {
        int M = 5;
        int N = 25;
        GetDigitSequence(M, N);
    }
}
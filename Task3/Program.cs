using System;

class Program
{

    static void ReverseArray(int[] array)
    {
        if (array.Length == 0)
        {
            return;

        }
        ReverseArray(array.Skip(1).ToArray());
        Console.Write(array[0] + " ");
    }

    static void Main(string[] args)
    {
        int [] array = {1, 2, 5, 0, 10, 34};
        ReverseArray(array);
    }
}
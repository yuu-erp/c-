using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số N: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Tổng các số từ 1 đến {N} là: {sum}");
    }
}

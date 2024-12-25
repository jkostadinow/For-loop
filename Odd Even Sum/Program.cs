using System;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (i % 2== 0)
                {
                    sumEven += currNumber; 
                }
                else
                {
                    sumOdd += currNumber;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}

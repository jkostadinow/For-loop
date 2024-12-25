using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 1; i <= n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                sumLeft += currNumber; 
            }
            for (int i = 1; i <= n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                sumRight += currNumber;
            }
            if (sumLeft != sumRight)
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
        }
    }
}

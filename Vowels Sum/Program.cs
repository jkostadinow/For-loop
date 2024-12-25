using System;

namespace Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currCh =text[i];
                
                if (currCh == 'a')
                {
                    sum += 1;
                }
                else if (currCh == 'e')
                {
                    sum += 2;
                }
                else if (currCh == 'i')
                {
                    sum += 3;
                }
                else if (currCh == 'o')
                {
                    sum += 4;
                }
                else if (currCh == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

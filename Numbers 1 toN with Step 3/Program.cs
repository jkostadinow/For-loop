﻿using System;

namespace Numbers_1_toN_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1;i <= n ; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

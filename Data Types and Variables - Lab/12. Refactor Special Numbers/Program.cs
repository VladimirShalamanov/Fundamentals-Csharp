﻿using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNum = 0;
            bool isSpecialNum = false;
            for (int i = 1; i <= n; i++)
            {
                currentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecialNum);
                sum = 0;
                i = currentNum;

            }
        }
    }
}

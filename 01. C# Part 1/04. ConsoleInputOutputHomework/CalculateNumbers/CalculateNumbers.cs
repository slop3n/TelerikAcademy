﻿using System;

class CalculateNumbers
{

    // Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
using System;

class ExchangeBits
{
    // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
   
    static void BitSwap(int firstBit, int secondBit, ref uint num)
    {
        uint bitOne = (num >> firstBit) & 1;
        uint bitTwo = (num >> secondBit) & 1;
        num = (uint)(num & (~(1 << firstBit)) | (bitTwo << firstBit));
        num = (uint)(num & (~(1 << secondBit)) | (bitOne << secondBit));
    }

    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        uint safe = n;
        BitSwap(3, 24, ref n);
        BitSwap(4, 25, ref n);
        BitSwap(5, 26, ref n);
        Console.WriteLine("Before reset: {0}\nAfter reset: {1}", Convert.ToString(safe, 2), Convert.ToString(n, 2));
    }
}
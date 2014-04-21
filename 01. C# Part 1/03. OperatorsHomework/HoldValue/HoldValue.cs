using System;

class HoldValue
{
    // We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n. Example: n = 5 (00000101), p=3, v=1  13 (00001101) n = 5 (00000101), p=2, v=0  1 (00000001)
    
    static void Main()
    {
        Console.Write("Please enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit you want to change: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the modifier ");
        int v = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int mask = v << p;
            int maskAndNum = mask | num;
            Console.WriteLine("The modified number has a value of: {0}", maskAndNum);
        }
        if (v == 0)
        {
            int mask = ~(1 << p);
            int maskornum = mask & num;
            Console.WriteLine("The modified number has a value of: {0}", maskornum);
        }
    }
}


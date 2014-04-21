using System;

    class ExtractBit
    {
        // Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

        static void Main()
        {
            Console.Write("Please enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter the position of the bit you want to check: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int maskAndNum = mask & num;
            maskAndNum = maskAndNum >> p;
            Console.WriteLine("The extracted bit has a value of: {0}", maskAndNum);
        }
    }

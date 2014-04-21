using System;

class SumOfSubset
{

    //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 > 1+1-2=0.

    static void Main()
    {
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int d = int.Parse(Console.ReadLine());
        //int e = int.Parse(Console.ReadLine());
        int[] numbers = { 3, -2, 1, 1, -4 };
        for (int n1 = 0; n1 < numbers.Length; n1++)
        {
            for (int n2 = n1+1; n2 < numbers.Length; n2++)
            {
                if (numbers[n1] + numbers[n2] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", numbers[n1], numbers[n2]);
                }
                for (int n3 = n2+1; n3 < numbers.Length; n3++)
                {
                    if (numbers[n1]+numbers[n2]+numbers[n3]==0)
                    {
                        Console.WriteLine("{0}+{1}+{2}=0",numbers[n1], numbers[n2], numbers[n3]);
                    }
                    for (int n4 = n3 + 1; n4 < numbers.Length; n4++)
                    {
                        if (numbers[n1] + numbers[n2] + numbers[n3] + numbers[n4] == 0)
                        {
                            Console.WriteLine("{0}+{1}+{2}+{3}=0", numbers[n1], numbers[n2], numbers[n3], numbers[n4]);
                        }
                        for (int n5 = n4 + 1; n5 < numbers.Length; n5++)
                        {
                            if (numbers[n1] + numbers[n2] + numbers[n3] + numbers[n4] + numbers[n5] == 0)
                            {
                                Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", numbers[n1], numbers[n2], numbers[n3], numbers[n4], numbers[n5]);
                            }
                        }
                    }
                }
            }
        }
    }
}
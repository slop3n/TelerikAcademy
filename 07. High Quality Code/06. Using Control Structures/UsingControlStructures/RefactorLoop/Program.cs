namespace RefactorLoop
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            int expectedValue = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value was not found");
            }
        }
    }
}

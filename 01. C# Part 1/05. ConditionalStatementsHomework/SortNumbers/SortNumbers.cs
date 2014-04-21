using System;

class SortNumbers
{

    //Sort 3 real values in descending order using nested if statements.

    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b&&a>c )
        {
            if (b>c)
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", a, c, b);
            }
        }

        else if (b>a&&b>c)
        {
            if (a>c)
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", b, c ,a);
            }
            
        }

        else if (c>a&&c>b)
        {
            if (a>b)
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", c, b ,a);
            }
        }



    }
}

using System;

class PrintCards
{

    //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

    static void Main(string[] args)
    {
        string tmp="";
        for (int j = 0; j <4; j++)
        {
            switch (j)
            {
                case 0: tmp = "of clubs"; break;
                case 1: tmp = "of diamonds"; break;
                case 2: tmp = "of hearts"; break;
                case 3: tmp = "of spades"; break;
            }

            Console.WriteLine("A {0}", tmp);
            Console.WriteLine("2 {0}", tmp);
            Console.WriteLine("3 {0}", tmp);
            Console.WriteLine("4 {0}", tmp);
            Console.WriteLine("5 {0}", tmp);
            Console.WriteLine("6 {0}", tmp);
            Console.WriteLine("7 {0}", tmp);
            Console.WriteLine("8 {0}", tmp);
            Console.WriteLine("9 {0}", tmp);
            Console.WriteLine("10 {0}", tmp);
            Console.WriteLine("J {0}", tmp);
            Console.WriteLine("Q {0}", tmp);
            Console.WriteLine("K {0}\n", tmp); 
                
        }
}

using System;

class VariablePlusOne
{

    //Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

    static void Main()
    {
        Console.WriteLine("Enter 1 for int\nEnter 2 for double\nEnter 3 for string");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1: 
                    Console.WriteLine("enter int");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case 2: 
                    Console.WriteLine("enter double");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case 3:
                    Console.WriteLine("enter string");
                    string c = Console.ReadLine();
                    Console.WriteLine(c+"*");
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Not a valid choice");
        }
    }
}
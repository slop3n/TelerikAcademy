using System;

class BooleanVariable
{
    // Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

    static void Main()
    {
        Console.WriteLine("Are you a female?");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            bool isFemale = true;
            Console.WriteLine("You are a female");
        }
        else
        {
            bool isFemale = false;
            Console.WriteLine("You are not a female");
        }
    }
}


using System;

class AgeIn10Years
{
    static void Main(string[] args)
    {
        int currentYear = DateTime.Now.Year;

        Console.WriteLine("Enter your current age" + currentYear);

        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("In ten years you will be " + (age+10) + " years old");
    }
}


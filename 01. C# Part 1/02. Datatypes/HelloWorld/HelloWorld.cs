using System;

class HelloWorld
{
    // Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object text = hello + " " + world;
        string finalText = (string)text;
        Console.WriteLine(finalText);
    }
}


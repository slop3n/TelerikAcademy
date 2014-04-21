//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a List of strings.
        List<string> animals = new List<string>
	{
	    "stegosaurus",
	    "piranha",
	    "leopard",
	    "cat",
	    "bear",
	    "hyena"
	};
        // Send the List to the method.
        foreach (string animal in SortByLength(animals))
        {
            Console.WriteLine(animal);
        }
    }

    static IEnumerable<string> SortByLength(IEnumerable<string> animalsString)
    {
        // Use LINQ to sort the array received and return a copy.
        var sorted = from listOfStrings in animalsString
                     orderby listOfStrings.Length ascending
                     select listOfStrings;
        return sorted;
    }
}
using System;

class TwoFactoriels
{

    //Write a program that calculates N!/K! for given N and K (1<K<N).

    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double factorial = Factorial(n) / Factorial(k);
        Console.WriteLine("{0}! divided by {1}! is: {2}", n , k, factorial);

    }
    
    static double Factorial(double number)
    {
        double sum = 1;        
        for (int i = 1; i <= number; i++)
			{
			 sum *= i;
    	    }
        return sum;
    }
}
using System;

    class TwoFactorielsPart2
    {

        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        static void Main()
        {
            Console.WriteLine("Enter two numbers");
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double factorial = (Factorial(n) * Factorial(k)) / Factorial(k - n);


            Console.WriteLine("The result of {0}!*{1}!/({1}-{0})! is {2}", n,k,factorial);
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
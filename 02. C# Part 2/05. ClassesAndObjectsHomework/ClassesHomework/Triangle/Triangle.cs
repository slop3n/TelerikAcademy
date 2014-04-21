//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a way to find the surface area: ");
            Console.WriteLine("1: By entering side and altitude");
            Console.WriteLine("2: By entering three sides");
            Console.WriteLine("3: By entering two sides and the angle between them");
            int chosenMethod = int.Parse(Console.ReadLine());
            if (chosenMethod == 1)
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0:0.000} square centimeters", SideAndAltitude(side,altitude));
            }
            else if (chosenMethod == 2)
            {
                Console.WriteLine("Enter three sides: ");
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double sideC = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0:0.000} square centimeters", ThreeSides(sideA, sideB, sideC));
            }
            else if (chosenMethod == 3)
            {
                Console.WriteLine("Enter two sides");
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the angle between those sides");
                double sideDeg = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0:0.000} square centimeters", TwoSidesAndAngle(sideA, sideB, sideDeg));

            }
            else
            {
                Console.WriteLine("Please enter a valid choice");
            }
        }

        static double SideAndAltitude(double side, double altitude)
        {
            double result = (side * altitude) / 2;
            return result;
        }

        static double ThreeSides(double sideA, double sideB, double sideC)
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double halfMinusA = halfPerimeter - sideA;
            double halfMinusB = halfPerimeter - sideB;
            double halfMinusC = halfPerimeter - sideC;
            double underRoot = halfPerimeter * halfMinusA * halfMinusB * halfMinusC;
            double result = Math.Sqrt(underRoot);
            return result;
        }

        static double TwoSidesAndAngle(double sideA, double sideB, double angle)
        {
            double radiansAngle = angle * 0.0174532925;
            double result = (sideA * sideB * Math.Sin(radiansAngle))/2;
            return result;
        }
    }
}

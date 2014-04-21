namespace ConsoleApplication1
{
    using System;

    public class MainClass
    {
        static void Main()
        {
            var myPoint = new Point3D(2, 3, 4);
            var myPointTwo = new Point3D(3, 4, 5);
            double distance = CalculateDistance.CalculateDistanceBetweenPoints(myPoint, myPointTwo);
            Console.WriteLine(distance);
        }
    }
}

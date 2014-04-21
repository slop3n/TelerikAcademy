using System;

class WithinCircleOutOfRectangle
{
    // Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
    
    static void Main(string[] args)
    {
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());
        int circleX = 1;
        int circleY = 1;
        int radius = 3;
        int rect1 = 1;
        int rect2 = -1;
        int rect3 = 7;
        int rect4 = -3;
        bool insideCircle = Math.Pow(pointX - circleX, 2) + Math.Pow(pointY - circleY, 2) < Math.Pow(radius,2);
        bool outsideRect = pointX < rect1 || pointX > rect3 || pointY > rect2 || pointY < rect4;
        if (insideCircle && outsideRect)
        {
            Console.WriteLine("Its inside");
        }
        else
        {
            Console.WriteLine("Its outside");
        }
     }
}

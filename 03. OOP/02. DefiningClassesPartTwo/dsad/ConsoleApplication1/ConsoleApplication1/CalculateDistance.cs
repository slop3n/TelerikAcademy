using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class CalculateDistance
    {
        public static double CalculateDistanceBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Sqrt(
                ((firstPoint.x - secondPoint.x)*(firstPoint.x - secondPoint.x)) + 
                ((firstPoint.y - secondPoint.y)*(firstPoint.y - secondPoint.y)) +
                ((firstPoint.z - secondPoint.z)*(firstPoint.z - secondPoint.z))
                                     );
            return result;
        }
    }
}

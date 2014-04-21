using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class CalculationDistance
    {
        public static double Dsqrt(int number)
        {
            if(0 == number)
            {
                return 0;
            }
            int n = (number / 2) + 1;
            int n1 = (n + (number / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (number / n)) / 2;
            }
            return n;
        }

        private static int Power(int a)
        {
            return a * a;
        } 

        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Dsqrt(Power(firstPoint.x - secondPoint.x) + Power(firstPoint.y - secondPoint.y) + Power(firstPoint.z - secondPoint.z));
            return result;
        }
    }
}

namespace CohesionAndCoupling
{
    using System;

    static class MathUtils
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDiagonal3D(double width, double height, double depth)
        {
            double distance = Math.Sqrt((width * width) + (height * height) + (depth * depth));
            return distance;
        }

        public static double CalcDiagonal2D(double sideOne, double sideTwo)
        {
            double distance = Math.Sqrt((sideOne * sideOne) + (sideTwo * sideTwo));
            return distance;
        }
    }
}

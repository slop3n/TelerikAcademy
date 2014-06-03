﻿namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", MathUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", MathUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double x = 3;
            double y = 4;
            double z = 5;
            Console.WriteLine("Volume = {0:f2}", MathUtils.CalcVolume(x, y, z));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathUtils.CalcDiagonal3D(x, y, z));
            Console.WriteLine("Diagonal XY = {0:f2}", MathUtils.CalcDiagonal2D(x, y));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathUtils.CalcDiagonal2D(x, z));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathUtils.CalcDiagonal2D(y, z));
        }
    }
}

﻿namespace Shapes
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }

    }
}

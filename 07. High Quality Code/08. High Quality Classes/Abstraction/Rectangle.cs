namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }

        public override double Radius
        {
            get
            {
                throw new NotImplementedException("Rectangle does not have Radius");
            }
            set
            {
                throw new NotImplementedException("Rectangle does not have Radius");
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (base.Width + base.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = base.Width * base.Height;
            return surface;
        }
    }
}

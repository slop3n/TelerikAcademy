namespace VarsDataExpAndConstants
{
    using System;
    using System.Linq;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size area, double angle)
        {
            return new Size(
            Math.Abs(Math.Cos(angle)) * area.Width + Math.Abs(Math.Sin(angle)) * area.Height,
            Math.Abs(Math.Sin(angle)) * area.Width + Math.Abs(Math.Cos(angle)) * area.Height);
        }

    }
}
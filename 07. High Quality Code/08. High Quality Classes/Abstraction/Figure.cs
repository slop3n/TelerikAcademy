namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        private double width;
        private double height;
        private double radius;

        public Figure()
        {
        }

        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Width must be positive");
                }
                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Height must be positive");
                }
                this.height = value;
            }
        }

        public virtual double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive");
                }
                this.radius = value;
            }
        }
    }
}

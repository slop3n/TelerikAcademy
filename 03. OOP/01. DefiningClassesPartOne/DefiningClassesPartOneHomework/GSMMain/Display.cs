namespace GSMMain
{
    using System;

    public class Display
    {
        //fields
        private double? displayInches;
        private int? displayColors;

        //constructors
        
        public Display(double? inches, int? colors)
        {
            this.displayInches = inches;
            this.displayColors = colors;
        }

        //properties
        public int? DisplayColors 
        {
            get { return this.displayColors; }
            set 
            {
                if (value < 2)
                {
                    throw new ArgumentException("Colors cannot be less than two");
                }
                this.displayColors = value;
            }
        }

        public double? DisplayInches
        {
            get { return this.displayInches; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Display cannot be smaller than one inch");
                }
                this.displayInches = value;
            }
        }
    }
}

namespace ConsoleApplication1
{
    class Display
    {
        public Display(double? size = null, double? colors = null)
        {
            this.Inches = size;
            this.Colors = colors;
        }

        public double? Inches { get; set; }

        public double? Colors { get; set; }
    }
}
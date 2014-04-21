namespace ConsoleApplication1
{
    public struct Point3D
    {
        private const int startX = 0;
        private const int startY = 0;
        private const int startZ = 0;

        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public static Point3D PrintStartPoint()
        {
            return new Point3D(startX, startY, startZ);
        }

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Z = {2}", this.x, this.y, this.z);
        }
    }
}

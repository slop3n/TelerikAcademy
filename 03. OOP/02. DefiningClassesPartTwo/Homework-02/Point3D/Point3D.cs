using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            string result;
            result = "X = " + this.x + "\nY = " + this.y + "\nZ = " + this.z;
            return result;
        }

        private static readonly int startX = 0;
        private static readonly int startY = 0;
        private static readonly int startZ = 0;

        public static Point3D StartPoint()
        {
            return new Point3D(startX, startY, startZ);
        }
    }
}

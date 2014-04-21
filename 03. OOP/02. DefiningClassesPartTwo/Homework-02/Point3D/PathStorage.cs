using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class PathStorage
    {
        public static void SavePath(Path holde)
        {
            StreamWriter writer = new StreamWriter("../../path.txt");
            using (writer)
            {
                for (int i = 0; i < holde.path.Count; i++)
                {

                    writer.WriteLine(holde.path[i].x + " " + holde.path[i].y + " " + holde.path[i].z);

                }
            }
        }

        public static Path LoadPath(string file)
        {
            StreamReader reader = new StreamReader(file);
            Path pathList = new Path();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] pointCords = line.Split(' ');
                    Point3D Point = new Point3D(int.Parse(pointCords[0]), int.Parse(pointCords[1]), int.Parse(pointCords[2]));
                    pathList.path.Add(Point);
                    line = reader.ReadLine();
                }
            }
            return pathList;
        }
    }
}

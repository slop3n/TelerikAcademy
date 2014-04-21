using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter("../../path.txt");
            using (writer)
            {
                for (int i = 0; i < path.sequenceOfPoints.Count; i++)
                {
                    writer.Write(path.sequenceOfPoints[i].x + " " + path.sequenceOfPoints[i].y + " " + path.sequenceOfPoints[i].z);
                }
            }
        }


    }
}

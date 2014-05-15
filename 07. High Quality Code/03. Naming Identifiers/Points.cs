using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Points
    {
        string name;
        int playerPoints;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PlayerPoints
        {
            get { return playerPoints; }
            set { playerPoints = value; }
        }

        public Points() { }

        public Points(string name, int points)
        {
            this.name = name;
            this.playerPoints = points;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Ship
    {
        private string name;
        int pointXOne;
        int pointXTwo;
        int pointYOne;
        int pointYTwo;

        public Ship(string name, int pointXOne, int pointXTwo, int pointYOne, int pointYTwo)
        {
            this.Name = name;
        }

        public string Name
        {
            get;

            set
            {
                this.name = value;
            }
        }
    }
}

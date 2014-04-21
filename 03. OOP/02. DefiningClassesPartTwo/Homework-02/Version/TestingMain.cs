using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version
{
    [Version("3.5")]
    class TestingMain
    {
        public static void Main()
        {
            object[] version = typeof(TestingMain).GetCustomAttributes(typeof(Version), false);

            Console.WriteLine("Version: {0}", version[0]);
        }
    }
}

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GSMTest
    {
        public static void Test()
        {
            List<GSM> phones = new List<GSM>();
            phones.Add(new GSM("HTC", "One", 300, "you", null, null, 40, 3.4, 16.8));
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(phones[0]);
            Console.WriteLine(new string('*', 30));
            phones.Add(new GSM("Apple", "Iphone", null, null, null, null, 500, 3.4, null));
            Console.WriteLine(phones[1]);
            Console.WriteLine(new string('*', 30));
        }
    }
}

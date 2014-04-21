namespace GSMMain
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class GSMTest
    {
        public static void Test()
        {
            List<GSM> phones = new List<GSM>();
            phones.Add(new GSM("Samsung", "S4", "you", 404, "long lasting", 20, 250, BatteryType.LiIon, 4, 16));
            phones.Add(new GSM("HTC", "One", "me", 505, "long lasting", 30, 200, BatteryType.NiCd, 4, 16));
            Console.WriteLine(phones[0].ToString());
            Console.WriteLine("********************************");
            Console.WriteLine(phones[1].ToString());
            Console.WriteLine("********************************");
            //Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}

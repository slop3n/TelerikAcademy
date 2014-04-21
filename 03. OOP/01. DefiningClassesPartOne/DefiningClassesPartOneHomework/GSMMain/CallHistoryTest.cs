namespace GSMMain
{
    using System;
    public class CallHistoryTest
    {
        //Create an instance of the GSM class.
        public static void TestCallHistory()
        {
            GSM TestGSM = new GSM("Apple", "Iphone", 404, BatteryType.LiIon);

            //Add few calls.
            TestGSM.AddCallToHistory(088123456, 200);
            TestGSM.AddCallToHistory(088654321, 123);
            TestGSM.AddCallToHistory(088987654, 432);

            Console.WriteLine("********* Call History *********");

            TestGSM.ShowCallHistory();

            Console.WriteLine();
            Console.WriteLine("********* Price of all calls *********");

            TestGSM.TotalPriceOfTheCalls();
            Console.WriteLine();
            Console.WriteLine("********* Removed call from history *********");
            
            TestGSM.RemoveCallFromHistory(2);
            TestGSM.ShowCallHistory();
            TestGSM.TotalPriceOfTheCalls();

            Console.WriteLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=- Call History after clear =-=-=-=-=-=-=-=-=-=-=");
            TestGSM.ClearCallHistory();
            TestGSM.ShowCallHistory();
        }   
    }
}

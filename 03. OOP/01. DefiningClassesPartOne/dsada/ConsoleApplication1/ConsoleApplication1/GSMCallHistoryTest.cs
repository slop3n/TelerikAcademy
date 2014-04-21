namespace ConsoleApplication1
{
    using System;

    class GSMCallHistoryTest
    {
        public void TestCallHistory()
        {
            GSM newPhone = new GSM();
            newPhone.AddToCallHistory(0888123456, 500);
            newPhone.AddToCallHistory(0987123123, 421);
            Console.WriteLine("**********Call History**********");
            newPhone.ShowCallHistory();
        }
    }
}

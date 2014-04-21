namespace ConsoleApplication1
{
    using System;
    using System.Linq;

    class Call
    {
        public Call(int phoneNumber, int duration)
        {
            this.CallDate = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public int PhoneNumber { get; set; }

        public DateTime CallDate { get; private set; }

        public int Duration { get; private set; }
    }
}
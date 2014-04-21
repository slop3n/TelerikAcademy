namespace GSMMain
{
    using System;
    using System.Text;

    class Call
    {
        private DateTime callDate;
        private int dialedNumber;
        private int duration;

        public DateTime CallDate { get { return this.callDate; } }

        public int DialedNumber { get; set; }

        public int Duration { get { return this.duration; } }

        public Call(int dialedNumber, int duration)
        {
            this.callDate = DateTime.Now;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            decimal min = (decimal)duration / 60.0M;
            string minutes = Math.Round(min, 2).ToString();

            result.Append("Number: ").Append(dialedNumber).Append("\nDateTime: ").Append(callDate).Append("\nDuration: ").Append(minutes).Append("min");
            return result.ToString();
        }
    }
}

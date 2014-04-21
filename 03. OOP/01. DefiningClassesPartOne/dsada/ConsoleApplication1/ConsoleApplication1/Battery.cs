namespace ConsoleApplication1
{
    class Battery
    {
        
        public Battery(string model = null, int? talkTime = null, int? idleTime = null)
        {
            this.BatteryModel = model;
            this.HoursTalk = talkTime;
            this.HoursIdle = idleTime;
        }

        public string BatteryModel { get; set; }

        public int? HoursTalk { get; set; }

        public int? HoursIdle { get; set; }
    }   
}

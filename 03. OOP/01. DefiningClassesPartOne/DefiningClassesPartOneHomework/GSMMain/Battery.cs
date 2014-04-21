namespace GSMMain
{
    using System;

    public enum BatteryType { LiIon, NiMH, NiCd }

    public class Battery
    {
        //fields
        private string batteryModel;
        private int? batteryHoursTalk;
        private int? batteryHoursIdle;
        private BatteryType batteryType;

        //constructor
        public Battery(string model, int? hoursTalk, int? hoursIdle, BatteryType type)
        {
            this.batteryModel= model;
            this.batteryHoursIdle = hoursIdle;
            this.batteryHoursTalk = hoursTalk;
            this.batteryType = type;
        }

        //properties
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty");
                }
                this.batteryModel = value;
            }
        }

        public int? BatteryHoursTalk
        {
            get { return this.batteryHoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk cannot be less than zero");
                }
                this.batteryHoursTalk = value;
            }
        }

        public int? BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle cannot be less than zero");
                }
                this.batteryHoursIdle = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.BatteryType = value; }
        }
    }
}

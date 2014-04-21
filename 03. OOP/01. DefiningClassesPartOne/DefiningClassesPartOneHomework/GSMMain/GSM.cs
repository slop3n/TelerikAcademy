namespace GSMMain
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private const decimal pricePerMinute = 0.20M;

        private List<Call> callHistory = new List<Call>();   
        
        //constructors
        public GSM(string manufacturer, string model, string owner, int? price, string batteryModel, int? hoursTalkTime, int? hoursIdleTime, BatteryType type, double? inches, int? colors)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.Battery = new Battery(batteryModel, hoursTalkTime, hoursIdleTime, type);
            this.Display = new Display(inches, colors);
        }

        public GSM(string manufacturer, string model, int? price, BatteryType type) : this(manufacturer, model, null, price, null, null, null, type, null, null) 
        {
        }

        //enumeration produces an error, i dont know why, help
        //public static GSM IPhone4S
        //{
        //    get
        //    {
        //        GSM result = new GSM("Apple", "4S", "Me", 404, "Long lasting", 20, 200, BatteryType.LiIon, 3.5, 16);
        //        return result;
        //    }
        //}
        
        //properties
        public BatteryType? BatteryType { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }
        
        public string Manufacturer { get; set; }

        public string Model { get; set; }
        
        public string Owner { get; set; }
        
        public int? Price { get; set; }

        //call history methods
        public void AddCallToHistory(int phoneNumber, int duration)
        {
            Call conversation = new Call(phoneNumber, duration);
            callHistory.Add(conversation);
        }

        public void RemoveCallFromHistory(int index)
        {
            if (index == 0)
            {
                callHistory.RemoveAt(0);
            }
            this.callHistory.RemoveAt(index - 1);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void ShowCallHistory()
        {
            int i = 0;
        
            foreach (var conversation in callHistory)
            {
                i++;
                Console.WriteLine("{0}. " + conversation , i);
                Console.WriteLine("**********************************************");
            }
        }

        public void TotalPriceOfTheCalls()
        {
            decimal total = 0;

            foreach (var conversation in callHistory)
            {
                total += (conversation.Duration / 60.0M) * pricePerMinute;
            }
        }

        //override ToString
        public override string ToString()
        {
            return string.Format("Device manufacturer: {0}\nDevice model: {1}\nDevice owner: {2}\nPrice: {3}\nBattery model: {4}\nBattery hours talk: {5}\nBattery hours idle: {6}\nBattery type: {7}\nDisplay size: {8}in\nDisplay colors: {9}mil", this.Manufacturer, this.Model, this.Owner, this.Price, this.Battery.BatteryModel, this.Battery.BatteryHoursTalk, this.Battery.BatteryHoursIdle, this.BatteryType, this.Display.DisplayInches, this.Display.DisplayColors);            
        }
    }
}
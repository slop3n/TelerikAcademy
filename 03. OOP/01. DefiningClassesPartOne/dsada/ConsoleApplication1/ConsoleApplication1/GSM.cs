namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        private static int pricePerMinute = 1;
        private List<Call> callHistory = new List<Call>();
        private string model;
        private string manufacturer;

        public GSM() { }

        public GSM(string model, string manufacturer, int? price = null, string owner = null, string batteryType = null, int? talkTime = null, int? idleTime = null, double? size = null, double? colors = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = new Battery(batteryType, talkTime, idleTime);
            this.Display = new Display(size, colors);
        }

        public static GSM IPhone4S
        {
            get
            {
                var result = new GSM("Iphone", "Apple", 300, "me", "dsada", 40, 40, 2.3, 2.3);
                return result;
            }
        }
        
        public string Model 
        {
            get { return this.model; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Device must have a model");
                }
                this.model = value;
            }
        }

        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Device must have a manufacturer");
                }
                this.manufacturer = value;
            }
        }
        
        public int? Price { get; set; }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public void AddToCallHistory(int phoneNumber, int duration)
        {
            var Conversation = new Call(phoneNumber, duration);
            callHistory.Add(Conversation);
        }

        public void RemoveFromCallHistory(int indexer)
        {
            this.callHistory.RemoveAt(indexer);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void CalculatePriceOfCalls()
        {
            int total = 0;
            foreach (var conversation in callHistory)
            {
                total += (conversation.Duration / 60) * pricePerMinute;
            }
        }
        
        public void ShowCallHistory()
        {
            foreach (var conversation in callHistory)
            {
                Console.WriteLine(new string('*', 15));
                Console.WriteLine(conversation);
            }
        }

        public override string ToString()
        {
            return string.Format("Device model: {0}\nDevice manufacturer: {1}\nDevice price: {2}\nDevice Owner: {3}\nDevice battery type: {4}\nDevice idle hours {5}\nDevice talk hours {6}\nDevice display size {7}\nDevice display colors {8}m", this.Model , this.Manufacturer, this.Price, this.Owner, this.Battery.BatteryModel, this.Battery.HoursIdle, this.Battery.HoursTalk, this.Display.Inches, this.Display.Colors);
        }
    }
}
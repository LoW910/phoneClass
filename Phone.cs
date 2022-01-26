namespace Phone
{
    public abstract class Phone
    {
        // Fields
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;
        
        // Constructor
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
            VersionNumber = versionNumber;
            BatteryPercentage = batteryPercentage;
            Carrier = carrier;
            RingTone = ringTone;
        }

        // Properties
        public string VersionNumber { get => _versionNumber; set => _versionNumber = value; }
        public int BatteryPercentage { get => _batteryPercentage; set => _batteryPercentage = value; }
        public string Carrier { get => _carrier; set => _carrier = value; }
        public string RingTone { get => _ringTone; set => _ringTone = value; }


        // Method signature
        public abstract void DisplayInfo();
    }
}
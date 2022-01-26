namespace Phone
{
    class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine($" \n ############ \n VersionNumber: {VersionNumber}\n Battery Percentage: {BatteryPercentage} \n Carrier: {Carrier}\n RingTone: {RingTone} \n ########### \n");
        }

        public string Ring()
        {
            return RingTone;
        }

        public string Unlock()
        {
            return "Badda Bing unlocked";
        }
    }
}
namespace Phone
{
    class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
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
            return "Cha-Ching Unlocked";
        }
    }
}
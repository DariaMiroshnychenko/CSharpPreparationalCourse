using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Connectivity
    {
        public enum YesNo { Yes, No }
        public YesNo HasWiFi { get; set; }
        public YesNo HasGPS { get; set; }
        public YesNo HasBluetooth { get; set; }
        public YesNo SupportsNFC { get; set; }
        public Connectivity() : this(hasWifi: YesNo.Yes, 
                                     hasGPS: YesNo.Yes, 
                                     hasBluetooth: YesNo.Yes, 
                                     supportsNFC: YesNo.Yes)
        {

        }
        public Connectivity(YesNo hasWifi, YesNo hasGPS, YesNo hasBluetooth, YesNo supportsNFC)
        {
            this.HasWiFi = hasWifi;
            this.HasGPS = hasGPS;
            this.HasBluetooth = hasBluetooth;
            this.SupportsNFC = supportsNFC;
        }
        public override string ToString()
        {
            string wifi = "Wi-Fi: " + HasWiFi;
            string gps = "GPS: " + HasGPS;
            string bluetooth = "Bluetooth: " + HasBluetooth;
            string nfc = "NFC: " + SupportsNFC;

            return wifi + ", " + gps + ", " + bluetooth + ", " + nfc;
        }
    }
}

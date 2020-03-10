using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Battery
    {
        public enum YesNo { Yes, No }
        public int Capacity { get; set; } // in mAh
        public YesNo HasSupportForFastCharging { get; set; }
        public YesNo IsRemovable { get; set; }
        public int RunTimeTalk { get; set; } // in hours
        public int RunTimeStandBy { get; set; } // in hours
        public int RemainingChargeInPercent { get; set; }

        public Battery() : this(capacity: 3750, 
                                hasSupportForFastCharging: YesNo.No, 
                                isRemovable: YesNo.No, 
                                runTimeTalk: 21, 
                                runTimeStandBy: 662,
                                remainingChargeInPercent: 100)
        {

        }

        public Battery(int capacity, YesNo hasSupportForFastCharging, YesNo isRemovable, int runTimeTalk, int runTimeStandBy, int remainingChargeInPercent)
        {
            this.Capacity = capacity;
            this.HasSupportForFastCharging = hasSupportForFastCharging;
            this.IsRemovable = isRemovable;
            this.RunTimeTalk = runTimeTalk;
            this.RunTimeStandBy = runTimeStandBy;
            this.RemainingChargeInPercent = remainingChargeInPercent;
        }
        public void Charge()
        {
            // charge the battery
        }
        public string GiveAWarningAboutLowRemainingCharge()
        {
            string warningMessage = "";

            if (this.IsRunningLow())    
            {
                warningMessage = "Low battery remaining: " + this.RemainingChargeInPercent + "%.";
            }
            else if (this.IsEmpty())
            {
                warningMessage = "Battery is empty: " + this.RemainingChargeInPercent + "%. The device is going to shut down in 30 seconds.";
            }

            return warningMessage;
        }
        public bool IsRunningLow()
        {
            bool batteryIsRunningLow = false;

            if ((this.RemainingChargeInPercent == 20) || (this.RemainingChargeInPercent == 10))
            {
                batteryIsRunningLow = true;
            }

            return batteryIsRunningLow;
        }
        public bool IsEmpty()
        {
            bool batteryIsEmpty = false;

            if (this.RemainingChargeInPercent == 4)
            {
                batteryIsEmpty = true;
            }

            return batteryIsEmpty;
        }
        public override string ToString()
        {
            return Capacity + " mAh, is removable: " + IsRemovable + ", supports fast charging: " + HasSupportForFastCharging;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class Battery
    {
        public delegate void RemainingChargeChangedEventHandler(int currentPercent);
        public event RemainingChargeChangedEventHandler RemainingChargeChanged;

        public enum YesNo { Yes, No }
        public int Capacity { get; set; } // in mAh
        public YesNo HasSupportForFastCharging { get; set; }
        public YesNo IsRemovable { get; set; }
        public int RunTimeTalk { get; set; } // in hours
        public int RunTimeStandBy { get; set; } // in hours
        private int vRemainingChargeInPercent;
        public int RemainingChargeInPercent
        {
            get { return vRemainingChargeInPercent; }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Battery charge cannont be less than 0 or more than 100 percent!");
                }
                else
                {
                    vRemainingChargeInPercent = value;
                }
            }
        }
        public ITimer Timer { get; set; }
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

        public override string ToString()
        {
            return Capacity + " mAh, is removable: " + IsRemovable + ", supports fast charging: " + HasSupportForFastCharging;
        }

        public void OnRemainingChargeChanged(int percent)
        {
            InvokeRemainingChargeChanged(RemainingChargeChanged, percent);
        }

        public void InvokeRemainingChargeChanged(RemainingChargeChangedEventHandler remainingChargeChangedHandler, int percent)
        {
            remainingChargeChangedHandler?.Invoke(percent);
        }

        public bool IsEmpty()
        {
            bool batteryIsEmpty = false;

            if (RemainingChargeInPercent == 0)
            {
                batteryIsEmpty = true;
            }

            return batteryIsEmpty;
        }

        public bool IsFull()
        {
            bool batteryIsFull = false;

            if (RemainingChargeInPercent == 100)
            {
                batteryIsFull = true;
            }

            return batteryIsFull;
        }

        public abstract void Charge();

        public abstract void Discharge();

        public abstract void ProcessSwitchingOfChargingState();

        public abstract void StopOngoingChargingProcesses();

        public void ResetChargingProcess()
        {
            if (IsEmpty())
            {
                Charge();
            }
            else if (IsFull())
            {
                Discharge();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class BatteryBasedOnThreads : Battery
    {
        static object StateLock = new object();
        public Thread ChargeBatteryThread { get; set; }
        public Thread DischargeBatteryThread { get; set; }

        public override void Charge()
        {
            DischargeBatteryThread = StopRunningThread(DischargeBatteryThread);
            ChargeBatteryThread = SetupAndRunThread(ChargeBatteryThread, Charging);
        }

        public override void Discharge()
        {
            ChargeBatteryThread = StopRunningThread(ChargeBatteryThread);
            DischargeBatteryThread = SetupAndRunThread(DischargeBatteryThread, Discharging);
        }

        public Thread SetupAndRunThread(Thread thread, Action threadMethod)
        {
            if (thread == null)
            {
                thread = new Thread(new ThreadStart(() => threadMethod()));
                thread.IsBackground = true;

                try
                {
                    thread.Start();
                }
                catch (ThreadAbortException e)
                {
                    thread = null;
                }
            }

            return thread;
        }

        private void Discharging()
        {
            while (!IsEmpty())
            {
                lock(StateLock)
                {
                    RemainingChargeInPercent--;
                }
                OnRemainingChargeChanged(RemainingChargeInPercent);
                Timer.Wait(500);
            }
            ResetChargingProcess();
        }

        private void Charging()
        {
            while (!IsFull())
            {
                lock (StateLock)
                {
                    RemainingChargeInPercent++;
                }
                OnRemainingChargeChanged(RemainingChargeInPercent);
                Timer.Wait(500);
            }
            ResetChargingProcess();
        }

        public override void ProcessSwitchingOfChargingState()
        {
            if (ChargeBatteryThread == null)
            {
                Charge();
            }
            else
            {
                Discharge();
            }
        }

        private Thread StopRunningThread(Thread thread)
        {
            if (thread != null)
            {
                if (thread.IsAlive && !IsEmpty() && !IsFull())
                {
                    thread.Abort();
                }
                thread = null;
            }

            return thread;
        }

        public override void StopOngoingChargingProcesses()
        {
            ChargeBatteryThread = StopRunningThread(ChargeBatteryThread);
            DischargeBatteryThread = StopRunningThread(DischargeBatteryThread);
        }
    }
}

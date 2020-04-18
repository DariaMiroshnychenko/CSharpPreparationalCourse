using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class BatteryBasedOnTasks : Battery
    {
        public CancellationTokenSource ChargeCancellationTokenSource { get; set; }
        public CancellationTokenSource DischargeCancellationTokenSource { get; set; }
        public Task ChargeBatteryTask { get; set; }
        public Task DischargeBatteryTask { get; set; }

        public override void Charge()
        {
            StopDischarging();
            SetupAndRunCharging();
        }

        public override void Discharge()
        {
            StopCharging();
            SetupAndRunDischarging();
        }

        private void SetupAndRunDischarging()
        {
            if (DischargeBatteryTask == null)
            {
                DischargeCancellationTokenSource = new CancellationTokenSource();
                DischargeBatteryTask = new Task(() => Discharging());
                DischargeBatteryTask.Start();
            }
        }

        private void SetupAndRunCharging()
        {
            if (ChargeBatteryTask == null)
            {
                ChargeCancellationTokenSource = new CancellationTokenSource();
                ChargeBatteryTask = new Task(() => Charging());
                ChargeBatteryTask.Start();
            }
        }

        public void Discharging()
        {
            while (!IsEmpty())
            {
                bool cancellationTokenSourceIsNotPresent = DischargeCancellationTokenSource == null;
                bool cancellationIsRequested = DischargeCancellationTokenSource != null && DischargeCancellationTokenSource.Token.IsCancellationRequested;
                if (cancellationTokenSourceIsNotPresent || cancellationIsRequested)
                {
                    return;
                }

                RemainingChargeInPercent--;
                OnRemainingChargeChanged(RemainingChargeInPercent);
                Timer.Wait(500);
            }
            ResetChargingProcess();
        }

        public void Charging()
        {
            while (!IsFull())
            {
                bool cancellationTokenSourceIsNotPresent = ChargeCancellationTokenSource == null;
                bool cancellationIsRequested = ChargeCancellationTokenSource != null && ChargeCancellationTokenSource.Token.IsCancellationRequested;
                if (cancellationTokenSourceIsNotPresent || cancellationIsRequested)
                {
                    return;
                }

                RemainingChargeInPercent++;
                OnRemainingChargeChanged(RemainingChargeInPercent);
                Timer.Wait(500);
            }
            ResetChargingProcess();
        }

        public override void ProcessSwitchingOfChargingState()
        {
            if (ChargeBatteryTask != null)
            {
                Discharge();
            }
            else
            {
                Charge();
            }
        }

        public override void StopOngoingChargingProcesses()
        {
            StopCharging();
            StopDischarging();
        }

        private void StopDischarging()
        {
            if (DischargeBatteryTask != null)
            {
                if (DischargeCancellationTokenSource != null)
                {
                    DischargeCancellationTokenSource.Cancel();
                    DischargeCancellationTokenSource = null;
                    DischargeBatteryTask = null;
                }
            }
        }

        private void StopCharging()
        {
            if (ChargeBatteryTask != null)
            {
                if (ChargeCancellationTokenSource != null)
                {
                    ChargeCancellationTokenSource.Cancel();
                    ChargeCancellationTokenSource = null;
                    ChargeBatteryTask = null;
                }
            }
        }
    }
}

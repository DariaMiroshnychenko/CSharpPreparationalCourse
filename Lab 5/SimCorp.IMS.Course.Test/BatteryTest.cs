using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Course;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class BatteryTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Battery charge cannont be less than 0 or more than 100 percent!")]
        public void RemainingChargeCannotBeLessThanZero()
        {
            // Arrange
            Battery batteryBasedOnTasks = new BatteryBasedOnTasks();

            // Act
            batteryBasedOnTasks.RemainingChargeInPercent = -2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Battery charge cannont be less than 0 or more than 100 percent!")]
        public void RemainingChargeCannotBeMoreThan100()
        {
            // Arrange
            Battery batteryBasedOnTasks = new BatteryBasedOnTasks();

            // Act
            batteryBasedOnTasks.RemainingChargeInPercent = 102;
        }

        [TestMethod]
        public void RemainingChargeDecreasesWhileChargingThreadIsOff()
        {
            // Arrange
            BatteryBasedOnThreads batteryBasedOnThreads = new BatteryBasedOnThreads();
            int startRemainingCharge = 50;

            batteryBasedOnThreads.Timer = new FakeTimer();
            batteryBasedOnThreads.RemainingChargeChanged += (p) => 
            {
                batteryBasedOnThreads.StopOngoingChargingProcesses();
            };
            batteryBasedOnThreads.RemainingChargeInPercent = startRemainingCharge;

            // Act
            batteryBasedOnThreads.Discharge();
            batteryBasedOnThreads.DischargeBatteryThread.Join();

            //Assert
            bool remainingChargeHasBeenDecreased = batteryBasedOnThreads.RemainingChargeInPercent < startRemainingCharge;
            Assert.IsTrue(remainingChargeHasBeenDecreased);
        }

        [TestMethod]
        public void RemainingChargeIncreasesWhileDischargingThreadIsOff()
        {
            // Arrange
            BatteryBasedOnThreads batteryBasedOnThreads = new BatteryBasedOnThreads();
            int startRemainingCharge = 50;

            batteryBasedOnThreads.Timer = new FakeTimer();
            batteryBasedOnThreads.RemainingChargeChanged += (p) =>
            {
                batteryBasedOnThreads.StopOngoingChargingProcesses();
            };
            batteryBasedOnThreads.RemainingChargeInPercent = startRemainingCharge;

            // Act
            batteryBasedOnThreads.Charge();
            batteryBasedOnThreads.ChargeBatteryThread.Join();

            //Assert
            bool remainingChargeHasBeenIncreased = batteryBasedOnThreads.RemainingChargeInPercent > startRemainingCharge;
            Assert.IsTrue(remainingChargeHasBeenIncreased);
        }

        [TestMethod]
        public void RemainingChargeDecreasesWhileChargingTaskIsOff()
        {
            // Arrange
            BatteryBasedOnTasks batteryBasedOnTasks = new BatteryBasedOnTasks();
            int startRemainingCharge = 50;

            batteryBasedOnTasks.Timer = new FakeTimer();
            batteryBasedOnTasks.RemainingChargeChanged += (p) =>
            {
                batteryBasedOnTasks.StopOngoingChargingProcesses();
            };
            batteryBasedOnTasks.RemainingChargeInPercent = startRemainingCharge;

            // Act
            batteryBasedOnTasks.Discharge();
            batteryBasedOnTasks.DischargeBatteryTask?.Wait();

            //Assert
            bool remainingChargeHasBeenDecreased = batteryBasedOnTasks.RemainingChargeInPercent < startRemainingCharge;
            Assert.IsTrue(remainingChargeHasBeenDecreased);
        }

        [TestMethod]
        public void RemainingChargeIncreasesWhileDischargingTaskIsOff()
        {
            // Arrange
            BatteryBasedOnTasks batteryBasedOnTasks = new BatteryBasedOnTasks();
            int startRemainingCharge = 50;

            batteryBasedOnTasks.Timer = new FakeTimer();
            batteryBasedOnTasks.RemainingChargeInPercent = startRemainingCharge;
            batteryBasedOnTasks.RemainingChargeChanged += (p) =>
            {
                batteryBasedOnTasks.StopOngoingChargingProcesses();
            };
            
            // Act
            batteryBasedOnTasks.Charge();
            batteryBasedOnTasks.ChargeBatteryTask.Wait();

            //Assert
            bool remainingChargeHasBeenIncreased = batteryBasedOnTasks.RemainingChargeInPercent > startRemainingCharge;
            Assert.IsTrue(remainingChargeHasBeenIncreased);
        }
    }
}

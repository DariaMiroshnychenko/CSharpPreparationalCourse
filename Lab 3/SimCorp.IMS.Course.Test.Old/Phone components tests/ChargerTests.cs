using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class ChargerTests
    {
        [TestMethod]
        public void HuaweiPowerBankCharge()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            HuaweiPowerBank HuaweiPowerBank = new HuaweiPowerBank(VariableOutput);

            string expectedOutput = $"{nameof(HuaweiPowerBank)} is charging your phone";

            // Act
            HuaweiPowerBank.Charge();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void NokiaChargerCharge()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            NokiaCharger NokiaCharger = new NokiaCharger(VariableOutput);

            string expectedOutput = $"{nameof(NokiaCharger)} is charging your phone";

            // Act
            NokiaCharger.Charge();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void NomiPowerBankCharge()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            NomiPowerBank NomiPowerBank = new NomiPowerBank(VariableOutput);

            string expectedOutput = $"{nameof(NomiPowerBank)} is charging your phone";

            // Act
            NomiPowerBank.Charge();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void OwnChargerCharge()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            OwnCharger OwnCharger = new OwnCharger(VariableOutput);

            string expectedOutput = $"{nameof(OwnCharger)} is charging your phone";

            // Act
            OwnCharger.Charge();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void QQEERSolarPowerBankCharge()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            QQEERSolarPowerBank QQEERSolarPowerBank = new QQEERSolarPowerBank(VariableOutput);

            string expectedOutput = $"{nameof(QQEERSolarPowerBank)} is charging your phone";

            // Act
            QQEERSolarPowerBank.Charge();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

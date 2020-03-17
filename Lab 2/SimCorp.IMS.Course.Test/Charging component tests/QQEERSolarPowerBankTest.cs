using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class QQEERSolarPowerBankTest
    {
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

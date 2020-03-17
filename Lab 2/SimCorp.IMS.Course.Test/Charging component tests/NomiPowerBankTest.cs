using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class NomiPowerBankTest
    {
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
    }
}

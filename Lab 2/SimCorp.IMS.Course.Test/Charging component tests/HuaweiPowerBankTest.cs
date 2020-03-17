using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test.Charging_component_tests
{
    [TestClass]
    public class HuaweiPowerBankTest
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
    }
}

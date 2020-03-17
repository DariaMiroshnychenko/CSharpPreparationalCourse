using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class NokiaChargerTest
    {
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
    }
}

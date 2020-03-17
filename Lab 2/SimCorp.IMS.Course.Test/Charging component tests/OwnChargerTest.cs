using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class OwnChargerTest
    {
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
    }
}

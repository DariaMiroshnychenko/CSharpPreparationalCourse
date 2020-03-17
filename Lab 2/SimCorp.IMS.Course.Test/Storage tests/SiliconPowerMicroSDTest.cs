using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class SiliconPowerMicroSDTest
    {
        [TestMethod]
        public void SiliconPowerMicroSDStore()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            SiliconPowerMicroSD SiliconPowerMicroSD = new SiliconPowerMicroSD(VariableOutput);

            string expectedOutput = $"{nameof(SiliconPowerMicroSD)} has stored your data";

            // Act
            SiliconPowerMicroSD.Store(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

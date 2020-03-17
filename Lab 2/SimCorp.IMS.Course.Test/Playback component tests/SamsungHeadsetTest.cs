using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class SamsungHeadsetTest
    {
        [TestMethod]
        public void SamsungHeadsetPlay()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            SamsungHeadset SamsungHeadset = new SamsungHeadset(VariableOutput);

            string expectedOutput = $"{nameof(SamsungHeadset)} sound";

            // Act
            SamsungHeadset.Play(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

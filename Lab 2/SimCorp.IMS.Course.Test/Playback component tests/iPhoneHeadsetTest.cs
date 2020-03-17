using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class iPhoneHeadsetTest
    {
        [TestMethod]
        public void iPhoneHeadsetPlay()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            iPhoneHeadset iPhoneHeadset = new iPhoneHeadset(VariableOutput);

            string expectedOutput = $"{nameof(iPhoneHeadset)} sound";

            // Act
            iPhoneHeadset.Play(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

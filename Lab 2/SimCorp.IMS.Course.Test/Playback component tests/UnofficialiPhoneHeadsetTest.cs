using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class UnofficialiPhoneHeadsetTest
    {
        [TestMethod]
        public void UnofficialiPhoneHeadsetPlay()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            UnofficialiPhoneHeadset UnofficialiPhoneHeadset = new UnofficialiPhoneHeadset(VariableOutput);

            string expectedOutput = $"{nameof(UnofficialiPhoneHeadset)} sound";

            // Act
            UnofficialiPhoneHeadset.Play(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

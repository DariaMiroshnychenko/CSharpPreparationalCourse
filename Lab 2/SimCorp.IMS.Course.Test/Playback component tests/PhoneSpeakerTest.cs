using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class PhoneSpeakerTest
    {
        [TestMethod]
        public void PhoneSpeakerPlay()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            PhoneSpeaker PhoneSpeaker = new PhoneSpeaker(VariableOutput);

            string expectedOutput = $"{nameof(PhoneSpeaker)} sound";

            // Act
            PhoneSpeaker.Play(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

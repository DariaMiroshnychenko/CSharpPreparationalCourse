using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class PlaybackTests
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

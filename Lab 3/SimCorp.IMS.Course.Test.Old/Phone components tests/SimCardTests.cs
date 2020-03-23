using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class SimCardTests
    {
        [TestMethod]
        public void KyivstarSimCardConnectToLocalMobileNetwork()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            KyivstarSimCard KyivstarSimCard = new KyivstarSimCard(VariableOutput);

            string expectedOutput = $"{nameof(KyivstarSimCard)} has connected to the local mobile network";

            // Act
            KyivstarSimCard.ConnectToLocalMobileNetwork();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void LifecellSimCardConnectToLocalMobileNetwork()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            LifecellSimCard LifecellSimCard = new LifecellSimCard(VariableOutput);

            string expectedOutput = $"{nameof(LifecellSimCard)} has connected to the local mobile network";

            // Act
            LifecellSimCard.ConnectToLocalMobileNetwork();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void VodafoneSimCardConnectToLocalMobileNetwork()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            VodafoneSimCard VodafoneSimCard = new VodafoneSimCard(VariableOutput);

            string expectedOutput = $"{nameof(VodafoneSimCard)} has connected to the local mobile network";

            // Act
            VodafoneSimCard.ConnectToLocalMobileNetwork();
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

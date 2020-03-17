using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class VodafoneSimCardTest
    {
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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class KyivstarSimCardTest
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
    }
}

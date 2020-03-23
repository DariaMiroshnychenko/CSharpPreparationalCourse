using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test.SIM_card_tests
{
    [TestClass]
    public class LifecellSimCardTest
    {
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
    }
}

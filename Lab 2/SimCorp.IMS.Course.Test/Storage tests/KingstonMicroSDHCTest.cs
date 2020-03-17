using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class KingstonMicroSDHCTest
    {
        [TestMethod]
        public void KingstonMicroSDHCStore()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            KingstonMicroSDHC KingstonMicroSDHC = new KingstonMicroSDHC(VariableOutput);

            string expectedOutput = $"{nameof(KingstonMicroSDHC)} has stored your data";

            // Act
            KingstonMicroSDHC.Store(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

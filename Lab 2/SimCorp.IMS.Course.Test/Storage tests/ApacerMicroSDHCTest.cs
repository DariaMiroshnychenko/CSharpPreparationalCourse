using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class ApacerMicroSDHCTest
    {
        [TestMethod]
        public void ApacerMicroSDHCStore()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            ApacerMicroSDHC ApacerMicroSDHC = new ApacerMicroSDHC(VariableOutput);

            string expectedOutput = $"{nameof(ApacerMicroSDHC)} has stored your data";

            // Act
            ApacerMicroSDHC.Store(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

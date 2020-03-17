using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class SanDiskMicroSDXCTest
    {
        [TestMethod]
        public void SanDiskMicroSDXCStore()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            SanDiskMicroSDXC SanDiskMicroSDXC = new SanDiskMicroSDXC(VariableOutput);

            string expectedOutput = $"{nameof(SanDiskMicroSDXC)} has stored your data";

            // Act
            SanDiskMicroSDXC.Store(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class StorageTests
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

        [TestMethod]
        public void SiliconPowerMicroSDStore()
        {
            // Arrange
            string actualOutput = "";
            OutputForTesting VariableOutput = new OutputForTesting(actualOutput);
            SiliconPowerMicroSD SiliconPowerMicroSD = new SiliconPowerMicroSD(VariableOutput);

            string expectedOutput = $"{nameof(SiliconPowerMicroSD)} has stored your data";

            // Act
            SiliconPowerMicroSD.Store(new Object());
            actualOutput = VariableOutput.OutputVariable;

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

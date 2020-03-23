using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class FormatterTest
    {
        [TestMethod]
        public void NoFormattingTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.NoFormatting;

            string message = "Message #1 recieved.";
            string expectedMessage = message;

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void StartWithDateTimeFormatTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.StartWithDateTimeFormat;

            string message = "Message #1 recieved.";
            string expectedMessage = $"[{DateTime.Now}] {message}";

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void EndWithDateTimeFormatTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.EndWithDateTimeFormat;

            string message = "Message #1 recieved.";
            string expectedMessage = $"{message} [{DateTime.Now}]";

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void LowerCaseFormatTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.LowerCaseFormat;

            string message = "Message #1 recieved.";
            string expectedMessage = message.ToLower();

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void UpperCaseFormatTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.UpperCaseFormat;

            string message = "Message #1 recieved.";
            string expectedMessage = message.ToUpper();

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void EndWithMessageLengthFormatTest()
        {
            // Arrange
            Formatter formatter = new Formatter();
            formatter.Formatting += Formatter.EndWithMessageLengthFormat;

            string message = "Message #1 recieved.";
            string expectedMessage = $"{message} ({message.Length} symbols)";

            // Act
            var actualMessage = formatter.OnFormatting(message);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}

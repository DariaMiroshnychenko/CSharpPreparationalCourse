using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class SMSProviderTest
    {
        [TestMethod]
        public void OneMessageRaisesOneSMSReceivedEvent()
        {
            // Arrange
            bool eventWasRaised = false;

            SMSProvider smsProvider = new SMSProvider();
            smsProvider.SMSReceived += (m) => { eventWasRaised = true; };

            // Act
            smsProvider.GenerateMessages(1);
   
            // Assert
            Assert.IsTrue(eventWasRaised);
        }

        [TestMethod]
        public void TwoMessagesRaiseTwoSMSReceivedEvents()
        {
            // Arrange
            int timesEventWasRaised = 0;
            int numberOfMessages = 2;

            SMSProvider smsProvider = new SMSProvider();
            smsProvider.SMSReceived += (m) => { timesEventWasRaised++; };

            // Act
            smsProvider.GenerateMessages(numberOfMessages);

            // Assert
            Assert.AreEqual(numberOfMessages, timesEventWasRaised);
        }
    }
}

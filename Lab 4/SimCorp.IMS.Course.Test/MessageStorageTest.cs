using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class MessageStorageTest
    {
        [TestMethod]
        public void IncommingMessageIsAddedToStorage()
        {
            // Arrange
            SimCorpMobile simCorpMobile = new SimCorpMobile();
            MessageStorage messageStorage = new MessageStorage();
            simCorpMobile.MessageStorage = messageStorage;
            int numberOfMessages = 1;

            var expectedMessageStorageContent = new List<Message>();
            expectedMessageStorageContent.Add(new Message(1, "+380951112233", "Message #1 recieved.", DateTime.Today.AddDays(-numberOfMessages)));

            // Act
            simCorpMobile.GenerateMessages(numberOfMessages);
            var actualMessageStorageContent = simCorpMobile.MessageStorage.Messages;

            // Assert
            CollectionAssert.AreEqual(expectedMessageStorageContent, actualMessageStorageContent, new MessageComparer());
        }

        [TestMethod]
        public void AddMessageToStorageAndRaiseEvent()
        {
            // Arrange
            bool eventWasRaised = false;

            MessageStorage messageStorage = new MessageStorage();
            messageStorage.MessageIsAdded += (m) => { eventWasRaised = true; };

            Message messageToAdd = new Message(1, "+380950000001", "Message #1 recieved.", new DateTime(2020, 4, 2));

            var expectedMessageStorageContent = new List<Message>();
            expectedMessageStorageContent.Add(messageToAdd);

            // Act
            messageStorage.Add(messageToAdd);
            var actualMessageStorageContent = messageStorage.Messages;

            // Assert
            CollectionAssert.AreEqual(expectedMessageStorageContent, actualMessageStorageContent, new MessageComparer());
            Assert.IsTrue(eventWasRaised);
        }

        [TestMethod]
        public void RemoveMessageFromStorageAndRaiseEvent()
        {
            // Arrange
            bool eventWasRaised = false;

            MessageStorage messageStorage = new MessageStorage();
            messageStorage.MessageIsRemoved += (m) => { eventWasRaised = true; };

            Message messageToRemove = new Message(1, "+380950000001", "Message #1 recieved.", new DateTime(2020, 4, 2));
            Message messageThatLeaves = new Message(2, "+380950000002", "Message #2 recieved.", new DateTime(2020, 4, 3));

            messageStorage.Add(messageToRemove);
            messageStorage.Add(messageThatLeaves);

            var expectedMessageStorageContent = new List<Message>();
            expectedMessageStorageContent.Add(messageThatLeaves);

            // Act
            messageStorage.Remove(messageToRemove);
            var actualMessageStorageContent = messageStorage.Messages;

            // Assert
            CollectionAssert.AreEqual(expectedMessageStorageContent, actualMessageStorageContent, new MessageComparer());
            Assert.IsTrue(eventWasRaised);
        }
    }
}

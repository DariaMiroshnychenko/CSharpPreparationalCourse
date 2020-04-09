using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Course;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class FilterTest
    {
        [TestMethod]
        public void FilterBySender()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var selectedSender = "+380730000002";

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(2, "+380730000002", "Message #2 is recieved.", new DateTime(2020, 3, 28)));

            // Act
            var actualFilteredMessageList = Filter.FilterBySender(messagesToFilter, selectedSender).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterByContainingText()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var textToLookFor = "word";

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(1, "+380950000001", "Message #1 is recieved (word).", new DateTime(2020, 3, 25)));
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));

            // Act
            var actualFilteredMessageList = Filter.FilterByContainingText(messagesToFilter, textToLookFor).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterByRecievingTime()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var fromDate = new DateTime(2020, 3, 29);
            var toDate = new DateTime(2020, 4, 5);

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));

            // Act
            var actualFilteredMessageList = Filter.FilterByRecievingTime(messagesToFilter, fromDate, toDate).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterBySenderByContainingTextWithLogicOr()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var selectedSender = "+380950000003";
            var textToLookFor = "word";
            var andLogicSelected = false;
            var orLogicSelected = true;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, false);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Filter.FilterBySender(messagesToFilter, selectedSender));
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Filter.FilterByContainingText(messagesToFilter, textToLookFor));
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Enumerable.Empty<Message>());

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(1, "+380950000001", "Message #1 is recieved (word).", new DateTime(2020, 3, 25)));
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));
            expectedFilteredMessageList.Add(new Message(4, "+380950000003", "Message #4 is recieved.", new DateTime(2020, 4, 6)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected)
                                                  .OrderBy(m => m.MessageId)
                                                  .ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterBySenderByContainingTextWithLogicAnd()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var selectedSender = "+380950000003";
            var textToLookFor = "word";
            var andLogicSelected = true;
            var orLogicSelected = false;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, false);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Filter.FilterBySender(messagesToFilter, selectedSender));
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Filter.FilterByContainingText(messagesToFilter, textToLookFor));
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Enumerable.Empty<Message>());

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterBySenderByRecievingTimeWithLogicOr()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var selectedSender = "+380950000003";
            var fromDate = new DateTime(2020, 4, 4);
            var toDate = new DateTime(2020, 4, 8);
            var andLogicSelected = false;
            var orLogicSelected = true;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, false);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, true);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Filter.FilterBySender(messagesToFilter, selectedSender));
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Enumerable.Empty<Message>());
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Filter.FilterByRecievingTime(messagesToFilter, fromDate, toDate));

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));
            expectedFilteredMessageList.Add(new Message(4, "+380950000003", "Message #4 is recieved.", new DateTime(2020, 4, 6)));
            expectedFilteredMessageList.Add(new Message(5, "+380660000004", "Message #5 is recieved.", new DateTime(2020, 4, 7)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected)
                                                  .OrderBy(m => m.MessageId)
                                                  .ToList();
            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterBySenderByRecievingTimeWithLogicAnd()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var selectedSender = "+380950000003";
            var fromDate = new DateTime(2020, 4, 4);
            var toDate = new DateTime(2020, 4, 8);
            var andLogicSelected = true;
            var orLogicSelected = false;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, false);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, true);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Filter.FilterBySender(messagesToFilter, selectedSender));
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Enumerable.Empty<Message>());
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Filter.FilterByRecievingTime(messagesToFilter, fromDate, toDate));

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(4, "+380950000003", "Message #4 is recieved.", new DateTime(2020, 4, 6)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterByContainingTextByRecievingTimeWithLogicOr()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var textToLookFor = "word";
            var fromDate = new DateTime(2020, 3, 27);
            var toDate = new DateTime(2020, 4, 4);
            var andLogicSelected = false;
            var orLogicSelected = true;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, false);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, true);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Enumerable.Empty<Message>());
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Filter.FilterByContainingText(messagesToFilter, textToLookFor));
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Filter.FilterByRecievingTime(messagesToFilter, fromDate, toDate));

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(1, "+380950000001", "Message #1 is recieved (word).", new DateTime(2020, 3, 25)));
            expectedFilteredMessageList.Add(new Message(2, "+380730000002", "Message #2 is recieved.", new DateTime(2020, 3, 28)));
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected)
                                                  .OrderBy(m => m.MessageId)
                                                  .ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        [TestMethod]
        public void FilterByContainingTextByRecievingTimeWithLogicAnd()
        {
            // Arrange
            List<Message> messagesToFilter = GenerateTestMessageList();
            var textToLookFor = "word";
            var fromDate = new DateTime(2020, 3, 27);
            var toDate = new DateTime(2020, 4, 4);
            var andLogicSelected = true;
            var orLogicSelected = false;

            Dictionary<Filter.FilteringOptions, bool> selectedFiltering = new Dictionary<Filter.FilteringOptions, bool>();
            selectedFiltering.Add(Filter.FilteringOptions.BySender, false);
            selectedFiltering.Add(Filter.FilteringOptions.ByContainingText, true);
            selectedFiltering.Add(Filter.FilteringOptions.ByDate, true);

            Dictionary<Filter.FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<Filter.FilteringOptions, IEnumerable<Message>>();
            filteredEnumerables.Add(Filter.FilteringOptions.BySender, Enumerable.Empty<Message>());
            filteredEnumerables.Add(Filter.FilteringOptions.ByContainingText, Filter.FilterByContainingText(messagesToFilter, textToLookFor));
            filteredEnumerables.Add(Filter.FilteringOptions.ByDate, Filter.FilterByRecievingTime(messagesToFilter, fromDate, toDate));

            var expectedFilteredMessageList = new List<Message>();
            expectedFilteredMessageList.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));

            // Act
            var actualFilteredMessageList = Filter.ApplyAndOrLogic(messagesToFilter, selectedFiltering, filteredEnumerables, andLogicSelected, orLogicSelected).ToList();

            // Assert
            CollectionAssert.AreEqual(expectedFilteredMessageList, actualFilteredMessageList, new MessageComparer());
        }

        public List<Message> GenerateTestMessageList()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message(1, "+380950000001", "Message #1 is recieved (word).", new DateTime(2020, 3, 25)));
            messages.Add(new Message(2, "+380730000002", "Message #2 is recieved.", new DateTime(2020, 3, 28)));
            messages.Add(new Message(3, "+380950000003", "Message #3 is recieved (word).", new DateTime(2020, 4, 3)));
            messages.Add(new Message(4, "+380950000003", "Message #4 is recieved.", new DateTime(2020, 4, 6)));
            messages.Add(new Message(5, "+380660000004", "Message #5 is recieved.", new DateTime(2020, 4, 7)));

            return messages;
        }
    }
}

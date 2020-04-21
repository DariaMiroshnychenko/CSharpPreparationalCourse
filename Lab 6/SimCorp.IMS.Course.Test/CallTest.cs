using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using SimCorp.IMS.Course;
using static SimCorp.IMS.Course.Call;

namespace SimCorp.IMS.Course.Test
{
    [TestClass]
    public class CallTest
    {
        [TestMethod]
        public void CallsAreSortedWhileAddingNewCall()
        {
            // Arrange
            SortedSet<Call> callList = new SortedSet<Call>();

            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("+380961112233");
            phoneNumbers.Add("+380667778899");
            phoneNumbers.Add("+380734445566");
            phoneNumbers.Add("+380952223344");

            callList.Add(new Call(new Contact(1, "Contact 1", new List<string>(phoneNumbers.Take(1))), "+380961112233", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3)));
            callList.Add(new Call(new Contact(2, "Contact 2", new List<string>(phoneNumbers.Take(2))), "+380667778899", new DateTime(2020, 4, 19, 13, 9, 2), CallDirections.Incomming, new TimeSpan(0, 1, 23)));
            callList.Add(new Call(new Contact(3, "Contact 3", new List<string>(phoneNumbers.Take(3))), "+380734445566", new DateTime(2020, 4, 19, 22, 8, 10), CallDirections.Outgoing, new TimeSpan(0, 0, 46)));

            Call newCall = new Call(new Contact(4, "Contact 4", new List<string>(phoneNumbers.Take(4))), phoneNumbers.ElementAt(3), new DateTime(2020, 4, 19, 17, 45, 31), CallDirections.Incomming, new TimeSpan(0, 2, 34));

            // Act
            callList.Add(newCall);

            //Assert
            Assert.IsTrue(callList.ElementAt(1).Equals(newCall));
        }

        [TestMethod]
        public void CallsAreSortedWhileRemovingCall()
        {
            // Arrange
            SortedSet<Call> callList = new SortedSet<Call>();

            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("+380961112233");
            phoneNumbers.Add("+380667778899");
            phoneNumbers.Add("+380734445566");

            Call firstCall = new Call(new Contact(1, "Contact 1", new List<string>(phoneNumbers.Take(1))), phoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 22, 8, 10), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call secondCall = new Call(new Contact(2, "Contact 2", new List<string>(phoneNumbers.Take(2))), phoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 13, 9, 2), CallDirections.Incomming, new TimeSpan(0, 1, 23));
            Call thirdCall = new Call(new Contact(3, "Contact 3", new List<string>(phoneNumbers.Take(3))), phoneNumbers.ElementAt(2), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 0, 46));

            callList.Add(firstCall);
            callList.Add(secondCall);
            callList.Add(thirdCall);

            // Act
            callList.Remove(secondCall);

            //Assert
            Assert.IsTrue(callList.ElementAt(0).Equals(firstCall));
            Assert.IsTrue(callList.ElementAt(1).Equals(thirdCall));
        }

        [TestMethod]
        public void NullAndCallComparison()
        {
            // Arrange
            Call callX = null;
            Call callY = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));

            int expectedComparisonResult = 1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void NullAndCallEqualityCheck()
        {
            // Arrange
            Call callX = null;
            Call callY = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameReferenceCallsComparison()
        {
            // Arrange
            Call callX = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = callX;

            int expectedComparisonResult = 0;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameReferenceCallsEqualityCheck()
        {
            // Arrange
            Call callX = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = callX;

            bool expectedEqualityCheckResult = true;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CallAndObjectOfAnotherTypeComparison()
        {
            // Arrange
            Call callX = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            string callY = "callY";

            // Act
            int actualComparisonResult = callY.CompareTo(callX);
        }

        [TestMethod]
        public void CallAndObjectOfAnotherTypeEqualotyCheck()
        {
            // Arrange
            Call callX = new Call(new Contact(3, "Contact 3", new List<string>(new[] { "+380950000001" })), "+380950000001", new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            string callY = "callY";

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameContactPhoneDirectionDifferentTimeComparison()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 4, 51));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameContactPhoneDirectionDifferentTimeEqualityCheck()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 20, 11));

            bool expectedEqualityCheckResult = true;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameContactDirectionDifferentPhoneTimeComparison()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 10, 21));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameContactDirectionDifferentPhoneTimeEqualityCheck()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 16, 20));

            bool expectedEqualityCheckResult = true;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameContactDifferentDirectionPhoneTimeComparison()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 12, 7));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameContactDifferentDirectionPhoneTimeEqualityCheck()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 56, 1));

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameContactPhoneDifferentDirectionTimeComparison()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 8, 5));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameContactPhoneDifferentDirectionTimeEqualityCheck()
        {
            // Arrange
            Contact contact = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));

            Call callX = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contact, contact.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 10, 45));

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void SameDirectionDifferentContactPhoneTimeComparison()
        {
            // Arrange
            Contact contactX = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            Contact contactY = new Contact(2, "Contact 2", new List<string>(new[] { "+380950000003", "+380950000004" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contactX, contactX.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contactY, contactY.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 32, 9));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void SameDirectionDifferentContactPhoneTimeEqualityCheck()
        {
            // Arrange
            Contact contactX = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            Contact contactY = new Contact(2, "Contact 2", new List<string>(new[] { "+380950000003", "+380950000004" }));
            CallDirections callDirection = CallDirections.Outgoing;

            Call callX = new Call(contactX, contactX.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), callDirection, new TimeSpan(0, 2, 3));
            Call callY = new Call(contactY, contactY.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), callDirection, new TimeSpan(0, 32, 43));

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }

        [TestMethod]
        public void DifferentContactPhoneDirectionTimeComparison()
        {
            // Arrange
            Contact contactX = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            Contact contactY = new Contact(2, "Contact 2", new List<string>(new[] { "+380950000003", "+380950000004" }));

            Call callX = new Call(contactX, contactX.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contactY, contactY.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 18, 31));

            int expectedComparisonResult = -1;

            // Act
            int actualComparisonResult = callY.CompareTo(callX);

            //Assert
            Assert.AreEqual(expectedComparisonResult, actualComparisonResult);
        }

        [TestMethod]
        public void DifferentContactPhoneDirectionTimeEqualityCheck()
        {
            // Arrange
            Contact contactX = new Contact(1, "Contact 1", new List<string>(new[] { "+380950000001", "+380950000002" }));
            Contact contactY = new Contact(2, "Contact 2", new List<string>(new[] { "+380950000003", "+380950000004" }));

            Call callX = new Call(contactX, contactX.PhoneNumbers.ElementAt(0), new DateTime(2020, 4, 19, 9, 20, 1), CallDirections.Outgoing, new TimeSpan(0, 2, 3));
            Call callY = new Call(contactY, contactY.PhoneNumbers.ElementAt(1), new DateTime(2020, 4, 19, 10, 00, 05), CallDirections.Incomming, new TimeSpan(0, 7, 25));

            bool expectedEqualityCheckResult = false;

            // Act
            bool actualEqualityCheckResult = callY.Equals(callX);

            //Assert
            Assert.AreEqual(expectedEqualityCheckResult, actualEqualityCheckResult);
        }
    }
}

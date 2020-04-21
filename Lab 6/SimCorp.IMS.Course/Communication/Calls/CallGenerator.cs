using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SimCorp.IMS.Course.Call;

namespace SimCorp.IMS.Course
{
    public class CallGenerator
    {
        const int numberOfHoursInDay = 24;
        const int numberOfMinutesInHour = 60;
        const int numberOfSecondsInMinute = 60;

        public delegate void CallGeneratedEventHandler(Call call);
        public event CallGeneratedEventHandler CallGenerated;

        public async Task GenerateCalls(int numberOfCalls)
        {
            await Task.Run(() => GeneratingCalls(numberOfCalls));
        }

        public void GeneratingCalls(int numberOfCalls)
        {
            Random randomGenerator = new Random();
            DateTime startCallTime = DateTime.Today.AddDays(-numberOfCalls);
            List<Contact> contacts = GetContacts();

            Contact contact;
            string phoneNumber;
            DateTime callTime;
            CallDirections callDirection;
            TimeSpan callDuration;

            for (int i = 0; i < numberOfCalls; i++)
            {
                contact = contacts.ElementAt(randomGenerator.Next(0, contacts.Count));
                phoneNumber = contact.PhoneNumbers.ElementAt(randomGenerator.Next(0, contact.PhoneNumbers.Count));
                callTime = startCallTime.AddDays(i).AddHours(randomGenerator.Next(0, numberOfHoursInDay)).AddMinutes(randomGenerator.Next(0, numberOfMinutesInHour));
                callDirection = (CallDirections)Math.Round(randomGenerator.NextDouble());
                callDuration = new TimeSpan(0, randomGenerator.Next(0, numberOfMinutesInHour), randomGenerator.Next(0, numberOfSecondsInMinute));

                OnCallGenerated(new Call(contact, phoneNumber, callTime, callDirection, callDuration));
            }
        }

        private void OnCallGenerated(Call call)
        {
            InvokeCallGenerated(CallGenerated, call);
        }

        private void InvokeCallGenerated(CallGeneratedEventHandler callGeneratedEventHandler, Call call)
        {
            callGeneratedEventHandler?.Invoke(call);
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact(1, "First contact", new List<string>(new[] { "+380950000001", "+380730000002" })));
            contacts.Add(new Contact(2, "Second contact", new List<string>(new[] { "+380660000003"})));
            contacts.Add(new Contact(3, "Third contact", new List<string>(new[] { "+380980000004", "+380980000005", "+380500000006" })));
            contacts.Add(new Contact(4, "Fourth contact", new List<string>(new[] { "+380500000007", "+380730000008" })));
            contacts.Add(new Contact(5, "Fifth contact", new List<string>(new[] { "+380950000009", "+380730000010", "+380500000011" })));

            return contacts;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SMSProvider
    { 
        public delegate void SMSReceivedHandler(Message message);
        public event SMSReceivedHandler SMSReceived;

        public void GenerateMessages(int numberOfMessages)
        {
            string[] senderPhoneNumbers = new string[] { "+380951112233", "+380731112233", "+380954445566", "+380734445566" };
            DateTime startRecievingTime = DateTime.Today.AddDays(-numberOfMessages);
            int messageId;
            string phoneNumber;
            string text;
            DateTime recievingTime;

            int senderIndex = senderPhoneNumbers.Length - 1;
            for (int i = 0; i < numberOfMessages; i++)
            {
                senderIndex = ResetSenderIndex(senderPhoneNumbers, senderIndex);

                messageId = i + 1;
                phoneNumber = senderPhoneNumbers[senderIndex];
                recievingTime = startRecievingTime.AddDays(i);
                text = $"Message #{i + 1} recieved.";

                OnSMSRecieved(new Message(messageId, phoneNumber, text, recievingTime));
            }
        }

        private static int ResetSenderIndex(string[] senderPhoneNumbers, int senderIndex)
        {
            if (senderIndex == senderPhoneNumbers.Length - 1)
            {
                senderIndex = 0;
            }
            else
            {
                senderIndex++;
            }

            return senderIndex;
        }

        public void OnSMSRecieved(Message message)
        {
            InvokeSMSReceived(SMSReceived, message);
        }

        private void InvokeSMSReceived(SMSReceivedHandler smsReceivedHandler, Message message)
        {
            smsReceivedHandler?.Invoke(message);
        }
    }
}

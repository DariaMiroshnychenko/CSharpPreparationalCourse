using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class SMSProvider
    { 
        public delegate void SMSReceivedHandler(Message message);
        public event SMSReceivedHandler SMSReceived;

        public ITimer Timer { get; set; }

        public Message GenerateNewMessage(int iteration, string sender, DateTime startRecievingTime)
        {
            int messageId = iteration + 1;
            string phoneNumber = sender;
            DateTime recievingTime = startRecievingTime.AddDays(iteration);
            string text = $"Message #{iteration + 1} recieved.";

            return new Message(messageId, phoneNumber, text, recievingTime);
        }

       public int ResetSenderIndex(string[] senderPhoneNumbers, int senderIndex)
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

        public abstract void GenerateMessages(int numberOfMessages);

        public abstract void Start(int numberOfMessages);

        public abstract void Stop();
    }
}

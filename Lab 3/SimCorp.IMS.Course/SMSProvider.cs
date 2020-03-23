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
        public delegate void SMSReceivedHandler(string message);
        public event SMSReceivedHandler SMSReceived;

        public void GenerateMessages(int maxNumberOfMessages)
        {
            for (int i = 0; i < maxNumberOfMessages; i++)
            {
                Thread.Sleep(1000);
                OnSMSRecieved($"Message #{i + 1} recieved.");
            }
        }

        public void OnSMSRecieved(string message)
        {
            InvokeSMSReceived(SMSReceived, message);
        }

        private void InvokeSMSReceived(SMSReceivedHandler smsReceivedHandler, string message)
        {
            smsReceivedHandler?.Invoke(message);
        }
    }
}

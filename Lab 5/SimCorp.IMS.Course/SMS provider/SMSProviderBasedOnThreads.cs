using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SMSProviderBasedOnThreads : SMSProvider
    {
        public Thread GeneratingMessagesThread { get; set; }

        public override void GenerateMessages(int numberOfMessages)
        {
            string[] senderPhoneNumbers = new string[] { "+380951112233", "+380731112233", "+380954445566", "+380734445566" };
            DateTime startRecievingTime = DateTime.Today.AddDays(-numberOfMessages);
            int senderIndex = senderPhoneNumbers.Length - 1;

            for (int i = 0; i < numberOfMessages; i++)
            {
                senderIndex = ResetSenderIndex(senderPhoneNumbers, senderIndex);
                Message generatedMessage = GenerateNewMessage(i, senderPhoneNumbers[senderIndex], startRecievingTime);
                OnSMSRecieved(generatedMessage);

                Timer.Wait(500);
            }
        }

        public override void Start(int numberOfMessages)
        {
            GeneratingMessagesThread = new Thread(n => GenerateMessages((int)n));
            GeneratingMessagesThread.IsBackground = true;
            try
            {
                GeneratingMessagesThread.Start(numberOfMessages);
            }
            catch (ThreadAbortException e)
            {
            }
        }

        public override void Stop()
        {
            if (GeneratingMessagesThread != null)
            {
                if (GeneratingMessagesThread.IsAlive)
                {
                    GeneratingMessagesThread.Abort();
                    GeneratingMessagesThread = null;
                }
            }
        }
    }
}

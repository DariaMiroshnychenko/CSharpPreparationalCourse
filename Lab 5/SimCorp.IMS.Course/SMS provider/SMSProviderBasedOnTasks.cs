using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SMSProviderBasedOnTasks : SMSProvider
    {
        CancellationTokenSource CancellationTokenSource { get; set; }

        public override void GenerateMessages(int numberOfMessages)
        {
            string[] senderPhoneNumbers = new string[] { "+380951112233", "+380731112233", "+380954445566", "+380734445566" };
            DateTime startRecievingTime = DateTime.Today.AddDays(-numberOfMessages);
            int senderIndex = senderPhoneNumbers.Length - 1;

            for (int i = 0; i < numberOfMessages; i++)
            {
                if (CancellationTokenSource.Token.IsCancellationRequested)
                {
                    return;
                }

                Thread.Sleep(500);
                senderIndex = ResetSenderIndex(senderPhoneNumbers, senderIndex);
                Message generatedMessage = GenerateNewMessage(i, senderPhoneNumbers[senderIndex], startRecievingTime);

                OnSMSRecieved(generatedMessage);
            }
        }

        public override void Start(int numberOfMessages)
        {
            if (CancellationTokenSource != null)
            {
                CancellationTokenSource.Cancel();
                CancellationTokenSource = null;
                return;
            }

            CancellationTokenSource = new CancellationTokenSource();
            Task GenerateMessagesTask = new Task(() => GenerateMessages(numberOfMessages));
            GenerateMessagesTask.Start();
        }

        public override void Stop()
        {
            CancellationTokenSource.Cancel();
        }
    }
}

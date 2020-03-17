using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class KyivstarSimCard : SimCard, ISimCard
    {
        private IOutput Output;

        public KyivstarSimCard()
        {

        }

        public KyivstarSimCard(IOutput output)
        {
            this.Output = output;
        }
        public void ConnectToLocalMobileNetwork()
        {
            Output.WriteLine($"{nameof(KyivstarSimCard)} has connected to the local mobile network");
        }

        public void PlaceCall(int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(KyivstarSimCard)} is placing a call to a number {phoneNumber}");
        }

        public void SendTextMessage(string message, int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(KyivstarSimCard)} has sent the message {message} to a number {phoneNumber}");
        }
    }
}

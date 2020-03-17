using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class LifecellSimCard : SimCard, ISimCard
    {
        private IOutput Output;

        public LifecellSimCard()
        {

        }

        public LifecellSimCard(IOutput output)
        {
            this.Output = output;
        }
        public void ConnectToLocalMobileNetwork()
        {
            Output.WriteLine($"{nameof(LifecellSimCard)} has connected to the local mobile network");
        }

        public void PlaceCall(int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(LifecellSimCard)} is placing a call to a number {phoneNumber}");
        }

        public void SendTextMessage(string message, int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(LifecellSimCard)} has sent the message {message} to a number {phoneNumber}");
        }
    }
}

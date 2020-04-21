using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class VodafoneSimCard : SimCard, ISimCard
    {
        private IOutput Output;

        public VodafoneSimCard()
        {

        }

        public VodafoneSimCard(IOutput output)
        {
            this.Output = output;
        }
        public void ConnectToLocalMobileNetwork()
        {
            Output.WriteLine($"{nameof(VodafoneSimCard)} has connected to the local mobile network");
        }

        public void PlaceCall(int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(VodafoneSimCard)} is placing a call to a number {phoneNumber}");
        }

        public void SendTextMessage(string message, int[] phoneNumber)
        {
            Output.WriteLine($"{nameof(VodafoneSimCard)} has sent the message {message} to a number {phoneNumber}");
        }
    }
}

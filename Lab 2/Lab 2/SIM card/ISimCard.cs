using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public interface ISimCard
    {
        void ConnectToLocalMobileNetwork();
        void SendTextMessage(string message, int[] phoneNumber);
        void PlaceCall(int[] phoneNumber);
    }
}

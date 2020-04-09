using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Message
    {
        public int MessageId { get; set; }
        public string PhoneNumber { get; set; }
        public string Text { get; set; }
        public DateTime RecievingTime { get; set; }

        public Message(int messageId, string phoneNumber, string text, DateTime recievingTime)
        {
            MessageId = messageId;
            PhoneNumber = phoneNumber;
            Text = text;
            RecievingTime = recievingTime;
        }
    }
}

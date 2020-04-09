using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course.Test
{
    public class MessageComparer : IComparer, IComparer<Message>
    {
        public int Compare(object x, object y)
        {
            return Compare((Message)x, (Message)y);
        }

        public int Compare(Message x, Message y)
        {
            if (x.MessageId.CompareTo(y.MessageId) != 0)
            {
                return x.MessageId.CompareTo(y.MessageId);
            }
            else if (x.PhoneNumber.CompareTo(y.PhoneNumber) != 0)
            {
                return x.PhoneNumber.CompareTo(y.PhoneNumber);
            }
            else if (x.Text.CompareTo(y.Text) != 0)
            {
                return x.Text.CompareTo(y.Text);
            }
            else if (x.RecievingTime.CompareTo(y.RecievingTime) != 0)
            {
                return x.RecievingTime.CompareTo(y.RecievingTime);
            }
            else
            {
                return 0;
            }
        }
    }
}

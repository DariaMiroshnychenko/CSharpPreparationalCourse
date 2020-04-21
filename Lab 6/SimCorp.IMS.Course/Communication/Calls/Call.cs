using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Call : IComparable, IComparable<Call>
    {
        public enum CallDirections
        {
            Incomming,
            Outgoing
        }

        public Contact Contact { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CallTime { get; set; }
        public CallDirections CallDirection { get; set; }
        public TimeSpan CallDuration { get; set; }
        public SortedSet<Call> LinkedCalls { get; set; } = new SortedSet<Call>();

        public Call(Contact contact, string phoneNumber, DateTime callTime, CallDirections callDirection, TimeSpan callDuration)
        {
            Contact = contact;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
            CallDirection = callDirection;
            CallDuration = callDuration;
        }

        public int CompareTo(object anotherObject)
        {
            if (anotherObject == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, anotherObject))
            {
                return 0;
            }

            if (this.GetType() != anotherObject.GetType())
            {
                throw new ArgumentException("A Call instance was expected.", "anotherObject");
            }

            return this.CompareTo((Call)anotherObject);
        }

        public int CompareTo(Call anotherCall)
        {
            if (anotherCall == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, anotherCall))
            {
                return 0;
            }

            if (this.GetType() != anotherCall.GetType())
            {
                throw new ArgumentException("A Call instance was expected.", "anotherCall");
            }

            if (CallTime.CompareTo(anotherCall.CallTime) != 0)
            {
                return (-1)*CallTime.CompareTo(anotherCall.CallTime);
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object anotherObject)
        {
            if (anotherObject == null)
            {
                return false;
            }

            if (ReferenceEquals(this, anotherObject))
            {
                return true;
            }

            if (this.GetType() != anotherObject.GetType())
            {
                return false;
            }

            Call anotherCall = (Call)anotherObject;

            bool contactIsTheSame = Contact.Equals(anotherCall.Contact);
            bool callDirectionIsTheSame = CallDirection.CompareTo(anotherCall.CallDirection) == 0;

            return contactIsTheSame && callDirectionIsTheSame;
        }

        public static bool operator ==(Call x, Call y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Call x, Call y)
        {
            return !object.Equals(x, y);
        }

        public override int GetHashCode()
        {
            return this.Contact.GetHashCode() ^ this.CallDirection.GetHashCode();
        }
    }
}

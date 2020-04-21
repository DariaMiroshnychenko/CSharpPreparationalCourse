using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Contact(int contactId, string name, List<string> phoneNumbers)
        {
            ContactId = contactId;
            Name = name;
            PhoneNumbers = phoneNumbers;
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

            Contact anotherContact = (Contact)anotherObject;

            bool idIsTheSame = this.ContactId == anotherContact.ContactId;
            bool nameIsTheSame = this.Name == anotherContact.Name;
            bool phoneNumbersAreTheSame = PhoneNumbers.SequenceEqual(anotherContact.PhoneNumbers);

            return idIsTheSame && nameIsTheSame && phoneNumbersAreTheSame;
        }

        public override int GetHashCode()
        {
            return this.ContactId.GetHashCode() ^ this.Name.GetHashCode() ^ this.PhoneNumbers.GetHashCode();
        }
    }
}

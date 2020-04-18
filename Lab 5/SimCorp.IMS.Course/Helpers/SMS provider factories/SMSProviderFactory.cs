using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class SMSProviderFactory
    {
        public abstract SMSProvider GetSMSProvider();
    }
}

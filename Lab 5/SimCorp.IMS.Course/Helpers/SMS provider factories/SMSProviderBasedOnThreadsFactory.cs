using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SMSProviderBasedOnThreadsFactory : SMSProviderFactory
    {
        public override SMSProvider GetSMSProvider()
        {
            return new SMSProviderBasedOnThreads();
        }
    }
}

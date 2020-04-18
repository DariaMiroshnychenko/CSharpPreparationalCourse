using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course.Test
{
    internal class FakeTimer : ITimer
    {
        public void Wait(int millisecondsTimeout)
        {
            // nothing to do
        }
    }
}

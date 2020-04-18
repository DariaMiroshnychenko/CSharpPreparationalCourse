using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public interface ITimer
    {
        void Wait(int millisecondsTimeout);
    }
}

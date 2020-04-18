using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class BatteryBasedOnTasksFactory : BatteryFactory
    {
        public override Battery GetBattery()
        {
            return new BatteryBasedOnTasks();
        }
    }
}

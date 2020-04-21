using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class HuaweiPowerBank : ICharger
    {
        private IOutput Output;

        public HuaweiPowerBank()
        {

        }

        public HuaweiPowerBank(IOutput output)
        {
            this.Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(HuaweiPowerBank)} is charging your phone");
        }
    }
}


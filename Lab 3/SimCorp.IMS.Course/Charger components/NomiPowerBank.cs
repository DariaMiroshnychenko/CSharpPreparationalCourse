using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class NomiPowerBank : ICharger
    {
        private IOutput Output;

        public NomiPowerBank()
        {

        }

        public NomiPowerBank(IOutput output)
        {
            this.Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(NomiPowerBank)} is charging your phone");
        }
    }
}


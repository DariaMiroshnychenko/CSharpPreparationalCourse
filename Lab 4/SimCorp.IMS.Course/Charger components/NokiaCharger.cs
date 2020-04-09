using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class NokiaCharger : ICharger
    {
        private IOutput Output;

        public NokiaCharger()
        {

        }

        public NokiaCharger(IOutput output)
        {
            this.Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(NokiaCharger)} is charging your phone");
        }
    }
}

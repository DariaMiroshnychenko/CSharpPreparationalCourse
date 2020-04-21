using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class OwnCharger : ICharger
    {
        private IOutput Output;

        public OwnCharger()
        {

        }

        public OwnCharger(IOutput output)
        {
            this.Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(OwnCharger)} is charging your phone");
        }
    }
}

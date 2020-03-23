using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class QQEERSolarPowerBank : ICharger
    {
        private IOutput Output;

        public QQEERSolarPowerBank()
        {

        }

        public QQEERSolarPowerBank(IOutput output)
        {
            this.Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(QQEERSolarPowerBank)} is charging your phone");
        }
    }
}


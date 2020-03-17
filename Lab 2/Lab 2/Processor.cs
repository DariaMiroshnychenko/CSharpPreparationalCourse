using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Processor
    {
        public double Speed { get; set; } // in GHz
        public int CoreQty { get; set; }

        public Processor() : this(speed: 2.2, coreQty: 4)
        {

        }

        public Processor(double speed, int coreQty)
        {
            this.Speed = speed;
            this.CoreQty = coreQty;
        }

        public void GoIntoPowerSavingMode()
        {
            // performs actions to reduce battery usage (e.g., when a battery is runnig low)
        }

        public override string ToString()
        {
            return CoreQty + " cores, " + Speed + " GHz speed";
        }
    }
}

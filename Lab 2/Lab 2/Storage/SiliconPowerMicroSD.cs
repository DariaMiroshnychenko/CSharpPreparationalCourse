using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SiliconPowerMicroSD : RemovableStorage, IStorage
    {
        private IOutput Output;

        public SiliconPowerMicroSD()
        {

        }

        public SiliconPowerMicroSD(IOutput output)
        {
            this.Output = output;
        }
        public void Store(Object data)
        {
            Output.WriteLine($"{nameof(SiliconPowerMicroSD)} has stored your data");
        }
    }
}

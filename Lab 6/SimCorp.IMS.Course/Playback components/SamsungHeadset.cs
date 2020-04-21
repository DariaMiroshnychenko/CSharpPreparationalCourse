using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;

        public SamsungHeadset()
        {

        }

        public SamsungHeadset(IOutput output)
        {
            this.Output = output;
        }
        public void Play(Object sound)
        {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}

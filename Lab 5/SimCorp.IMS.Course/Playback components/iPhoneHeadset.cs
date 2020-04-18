using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset()
        {

        }

        public iPhoneHeadset(IOutput output)
        {
            this.Output = output;
        }

        public void Play(Object sound)
        {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}

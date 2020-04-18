using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class UnofficialiPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public UnofficialiPhoneHeadset()
        {

        }

        public UnofficialiPhoneHeadset(IOutput output)
        {
            this.Output = output;
        }
        public void Play(Object sound)
        {
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} sound");
        }
    }
}

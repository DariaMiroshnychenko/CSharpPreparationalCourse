using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SanDiskMicroSDXC : RemovableStorage, IStorage
    {
        private IOutput Output;

        public SanDiskMicroSDXC()
        {

        }

        public SanDiskMicroSDXC(IOutput output)
        {
            this.Output = output;
        }
        public void Store(Object data)
        {
            Output.WriteLine($"{nameof(SanDiskMicroSDXC)} has stored your data");
        }
    }
}

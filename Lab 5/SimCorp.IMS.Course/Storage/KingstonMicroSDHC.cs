using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class KingstonMicroSDHC : RemovableStorage, IStorage
    {
        private IOutput Output;

        public KingstonMicroSDHC()
        {

        }

        public KingstonMicroSDHC(IOutput output)
        {
            this.Output = output;
        }
        public void Store(Object data)
        {
            Output.WriteLine($"{nameof(KingstonMicroSDHC)} has stored your data");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class ApacerMicroSDHC : RemovableStorage, IStorage
    {
        private IOutput Output;

        public ApacerMicroSDHC()
        {

        }

        public ApacerMicroSDHC(IOutput output)
        {
            this.Output = output;
        }
        public void Store(Object data)
        {
            Output.WriteLine($"{nameof(ApacerMicroSDHC)} has stored your data");
        }
    }
}

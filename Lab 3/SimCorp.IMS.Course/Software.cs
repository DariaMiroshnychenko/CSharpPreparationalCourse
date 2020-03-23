using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Software
    {
        public string OperatingSystem { get; set; }
        public string Skin { get; set; }

        public Software() : this(operatingSystem: "Android 8.0 Oreo", skin: "EMUI 8.2")
        {

        }

        public Software(string operatingSystem, string skin)
        {
            this.OperatingSystem = operatingSystem;
            this.Skin = skin;
        }

        public override string ToString()
        {
            return OperatingSystem + " operating system";
        }
    }
}
   
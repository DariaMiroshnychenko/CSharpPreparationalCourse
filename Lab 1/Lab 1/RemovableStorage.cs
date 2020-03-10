using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class RemovableStorage
    {
        public enum RemovableStorageTypes
        {
            microSD,
            microSDHC,
            microSDXC
        }

        public RemovableStorageTypes Type { get; set; }

        public int vRemovableStorageUpTo;
        public int RemovableStorageUpTo    // in GB
        {
            get
            {
                return vRemovableStorageUpTo;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("A maximum storage capacity should be a positive number.");
                }
                else
                {
                    vRemovableStorageUpTo = value;
                }
            }
        } 

        public RemovableStorage() : this(type: RemovableStorageTypes.microSDXC, removableStorageUpTo: 400)
        {

        }

        public RemovableStorage(RemovableStorageTypes type, int removableStorageUpTo)
        {
            this.Type = type;
            this.RemovableStorageUpTo = removableStorageUpTo;
        }

        public override string ToString()
        {
            return Type + " up to " + RemovableStorageUpTo + "GB";
        }
    }
}

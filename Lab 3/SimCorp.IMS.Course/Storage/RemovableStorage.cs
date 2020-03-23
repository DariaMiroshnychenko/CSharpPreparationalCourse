using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class RemovableStorage
    {
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

        public RemovableStorage() : this(removableStorageUpTo: 400)
        {

        }

        public RemovableStorage(int removableStorageUpTo)
        {
            this.RemovableStorageUpTo = removableStorageUpTo;
        }

        public override string ToString()
        {
            return nameof(RemovableStorage) + " up to " + RemovableStorageUpTo + "GB";
        }
    }
}

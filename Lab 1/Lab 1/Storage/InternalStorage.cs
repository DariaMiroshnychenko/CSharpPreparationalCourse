using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class InternalStorage
    {
        public int RAM { get; set; } // in GB
        public int Storage { get; set; } // in GB

        public InternalStorage() : this(ram: 4, storage: 64)
        {

        }

        public InternalStorage(int ram, int storage)
        {
            this.RAM = ram;
            this.Storage = storage;
        }

        public override string ToString()
        {
            string ram = RAM + "GB of RAM";
            string storage = Storage + "GB of storage";

            return ram + ", " + storage;
        }
    }
}

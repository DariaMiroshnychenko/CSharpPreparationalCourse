using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.Course;

namespace SimCorp.IMS.Course.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile SimCorpMobile = new SimCorpMobile();
            Console.WriteLine(SimCorpMobile.GetDescription());

            Console.ReadKey();
        }
    }
}

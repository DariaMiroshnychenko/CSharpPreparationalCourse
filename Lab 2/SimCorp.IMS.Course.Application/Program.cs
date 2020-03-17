using SimCorp.IMS.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput ConsoleOutput = new ConsoleOutput();
            ConsoleInput ConsoleInput = new ConsoleInput();

            SimCorpMobile SimCorpMobile = new SimCorpMobile(ConsoleOutput);
            PhoneComponentsHandler phoneComponentsHandler = new PhoneComponentsHandler(output: ConsoleOutput, input: ConsoleInput);

            phoneComponentsHandler.SelectAndSetComponents(SimCorpMobile);

            Console.ReadKey();
        }
    }
}

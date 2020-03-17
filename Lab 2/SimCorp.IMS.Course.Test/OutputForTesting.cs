using SimCorp.IMS.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course.Test
{
    public class OutputForTesting : IOutput
    {
        public string OutputVariable { get; set; }

        public OutputForTesting(string outputVariable)
        {
            this.OutputVariable = outputVariable;
        }

        public void Write(string text)
        {
            OutputVariable = text;
        }

        public void WriteLine(string text)
        {
            OutputVariable += text;
        }
    }
}

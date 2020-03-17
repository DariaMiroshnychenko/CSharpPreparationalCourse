using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Course
{
    public class RichTextBoxOutput : IOutput
    {
        public RichTextBox RichTextBox { get; set; }

        public RichTextBoxOutput(RichTextBox richTextBox)
        {
            this.RichTextBox = richTextBox;
        }

        public void Write(string text)
        {
            RichTextBox.Text = text;
        }

        public void WriteLine(string text)
        {
            RichTextBox.Text += "\n" + text;
        }
    }
}

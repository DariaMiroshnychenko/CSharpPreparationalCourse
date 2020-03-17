using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Course
{
    public class TextBoxInput : IInput
    {
        TextBox TextBox { get; set; }

        public TextBoxInput(TextBox textBox)
        {
            this.TextBox = textBox;
        }

        public string ReadLine()
        {
            return TextBox.Text;
        }
    }
}

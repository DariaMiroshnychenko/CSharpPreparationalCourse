using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class ScreenBase
    {
        public double Size { get; set; } // in inches
        public int[] Resolution { get; set; }
        public int PixelsPerInch { get; set; }

        public abstract void ShowImage(IScreenImage screenImage);
        public abstract void ShowImage(IScreenImage screenImage, int brightness);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class LCDScreen : ColorfulScreen
    {
        public LCDScreen() : this(size: 6.5,
                                       resolution: new int[] { 2340, 1080 },
                                       pixelsPerInch: 397,
                                       numberOfColors: 16.7)
        {

        }

        public LCDScreen(double size, int[] resolution, int pixelsPerInch, double numberOfColors)
        {
            this.Size = size;
            this.Resolution = resolution;
            this.PixelsPerInch = pixelsPerInch;
            this.NumberOfColors = numberOfColors;
        }

        public override void ShowImage(IScreenImage screenImage)
        {
            // logic of displaying an image on an LCD screen
        }

        public override void ShowImage(IScreenImage screenImage, int brightness)
        {
            // logic of displaying an image on an LCD screen with a specified brightness
        }

        public override string ToString()
        {
            return "LCD Screen";
        }
    }
}

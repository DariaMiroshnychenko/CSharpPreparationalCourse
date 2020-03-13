using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen() : this(size: 4, 
                                         resolution: new int[] { 600, 500 }, 
                                         pixelsPerInch: 100)
        {

        }

        public MonochromeScreen(double size, int[] resolution, int pixelsPerInch)
        {
            this.Size = size;
            this.Resolution = resolution;
            this.PixelsPerInch = pixelsPerInch;
        }

        public override void ShowImage(IScreenImage screenImage)
        {
            // logic of displaying an image on a monochrome screen
        }

        public override void ShowImage(IScreenImage screenImage, int brightness)
        {
            // logic of displaying an image on a monochrome screen with a specified brightness
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}

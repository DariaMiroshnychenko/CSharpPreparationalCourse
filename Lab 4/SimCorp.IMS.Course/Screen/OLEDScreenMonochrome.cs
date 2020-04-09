using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class OLEDScreenMonochrome : MonochromeScreen
    {
        public OLEDScreenMonochrome() : this(size: 4, 
                                             resolution: new int[] { 800, 600 }, 
                                             pixelsPerInch: 52)
        {

        }

        public OLEDScreenMonochrome(double size, int[] resolution, int pixelsPerInch)
        {
            this.Size = size;
            this.Resolution = resolution;
            this.PixelsPerInch = pixelsPerInch;
        }

        public override void ShowImage(IScreenImage screenImage)
        {
            // logic of displaying an image on a monochrome OLED screen
        }

        public override void ShowImage(IScreenImage screenImage, int brightness)
        {
            // logic of displaying an image on a monochrome OLED screen with a specified brightness
        }

        public override string ToString()
        {
            return "Monochrome OLED Screen";
        }
    }
}

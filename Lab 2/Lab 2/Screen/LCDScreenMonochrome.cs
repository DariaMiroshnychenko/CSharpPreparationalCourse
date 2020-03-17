using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class LCDScreenMonochrome : MonochromeScreen
    {
        public LCDScreenMonochrome() : this(size: 6.5,
                                            resolution: new int[] { 2340, 1080 },
                                            pixelsPerInch: 397)
        {

        }

        public LCDScreenMonochrome(double size, int[] resolution, int pixelsPerInch)
        {
            this.Size = size;
            this.Resolution = resolution;
            this.PixelsPerInch = pixelsPerInch;
        }

        public override void ShowImage(IScreenImage screenImage)
        {
            // logic of displaying an image on a monochrome LCD screen
        }

        public override void ShowImage(IScreenImage screenImage, int brightness)
        {
            // logic of displaying an image on a monochrome LCD screen with a specified brightness
        }

        public override string ToString()
        {
            return "Monochrome LCD Screen";
        }
    }
}

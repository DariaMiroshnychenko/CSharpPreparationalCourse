using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Lens
    {
        public int Resolution { get; set; } // in megapixels
        public double Aperture { get; set; } // format "f/<value>"
        public int FocalLength { get; set; } // in mm
        public double PixelSize { get; set; } // in micrometers

        public Lens() : this(resolution: 10, aperture: 1.1, focalLength: 15, pixelSize: 1)
        {

        }

        public Lens(int resolution, double aperture, int focalLength, double pixelSize)
        {
            this.Resolution = resolution;
            this.Aperture = aperture;
            this.FocalLength = focalLength;
            this.PixelSize = pixelSize;
        }

        public void TakePhoto()
        {
            // logic of taking a photo
        }
        public void AutoFocus()
        {
            // performs regular auto-focus
        }
        public void ZoomIn(float zoomFactor)
        {
            // zoom in a picture
        }
        public void ZoomOut(float zoomFactor)
        {
            // zoom out a picture
        }
    }
}

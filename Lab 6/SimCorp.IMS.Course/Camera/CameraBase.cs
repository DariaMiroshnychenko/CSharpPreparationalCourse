using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class CameraBase
    {
        public void TakePhoto()
        {
            // logic of taking a picture
        }
        public void ImageStabilisation()
        {
            // logic of stabilisation of an image
        }
        public abstract void ZoomIn(float zoomFactor);
        public abstract void ZoomOut(float zoomFactor);
        public abstract void AutoFocus();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SingleRearCamera : CameraBase
    {
        public Lens WideLens { get; set; }

        public SingleRearCamera() : this(wideLens: new Lens(resolution: 12, aperture: 2.4, focalLength: 26, pixelSize: 1.4))
        {

        }

        public SingleRearCamera(Lens wideLens)
        {
            this.WideLens = wideLens;
        }

        public override void AutoFocus()
        {
            // performs regular auto-focus
        }

        public override void ZoomIn(float zoomFactor)
        {
            // digital zoom (this is what a single lens is capabale of) 
        }

        public override void ZoomOut(float zoomFactor)
        {
            // digital zoom (this is what a single lens is capabale of) 
        }

        public override string ToString()
        {
            return "Single Rear Camera";
        }
    }
}

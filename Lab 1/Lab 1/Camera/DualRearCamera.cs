using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class DualRearCamera : CameraBase
    {
        public Lens WideLens { get; set; }
        public Lens TelephotoLens { get; set; }

        public int vMaxOpticalZoomFactor;
        public int MaxOpticalZoomFactor
        {
            get
            {
                vMaxOpticalZoomFactor = 1;
                if ((WideLens.FocalLength != 0) && (TelephotoLens.FocalLength != 0))
                {
                    double zoomFactor = TelephotoLens.FocalLength / WideLens.FocalLength;
                    vMaxOpticalZoomFactor = Convert.ToInt32(Math.Round(zoomFactor));
                }
                else
                {
                    Console.WriteLine("Focal lengthes of the phone lenses are not properly defined.");
                }
                return vMaxOpticalZoomFactor;
            }
        }

        public DualRearCamera() : this(wideLens: new Lens(resolution: 12, aperture: 1.5, focalLength: 26, pixelSize: 1.4), 
                                       telephotoLens: new Lens(resolution: 16, aperture: 2.4, focalLength: 52, pixelSize: 1))
        {

        }

        public DualRearCamera(Lens wideLens, Lens telephotoLens)
        {
            this.WideLens = wideLens;
            this.TelephotoLens = telephotoLens;
        }

        public override void AutoFocus()
        {
            // performs Dual Pixel Phase Detection auto-focus
        }
        public override void ZoomIn(float zoomFactor)
        {
            // optical zooming in (which is possible thanks to second lens)
        }
        public override void ZoomOut(float zoomFactor)
        {
            // optical zooming out (which is possible thanks to second lens)
        }
        public void Panorama()
        {
            // taking multiple shots and stitching them together to create one wide shot (panorama view)
        }
        public override string ToString()
        {
            return "Dual Rear Camera, " + WideLens.Resolution + " and " + TelephotoLens.Resolution + " MP, " + MaxOpticalZoomFactor + "x optical zoom";
        }
    }
}
 
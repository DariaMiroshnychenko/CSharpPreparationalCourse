using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class TouchBase
    {
        public enum TouchTechnologies
        {
            Resistive,
            Capacitive,
            SurfaceAcousticalWave,
            Infrared
        }

        public TouchBase() : this(TouchTechnologies.Capacitive)
        {

        }

        public TouchBase(TouchTechnologies technology)
        {
            this.Technology = technology;
        }

        public TouchTechnologies Technology { get; set; }

        public abstract void onSingleTap(Touch touch);
        public abstract void onDoubleTap(Touch touch);
        public abstract void onPressAndHold(Touch touch);
        public abstract void onScroll(Touch touch);
        public abstract void onFlick(Touch touch);
        public override string ToString()
        {
            return Technology + " technology";
        }
    }
}

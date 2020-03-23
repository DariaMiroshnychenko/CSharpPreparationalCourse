using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SingleTouch : TouchBase
    {
        public SingleTouch() : base()
        {

        }

        public SingleTouch(TouchTechnologies technology) : base(technology)
        {

        }

        public override void onSingleTap(Touch touch)
        {
            Console.WriteLine("Processes a single tap in a way single touch screens do it.");
        }

        public override void onDoubleTap(Touch touch)
        {
            Console.WriteLine("Processes a double tap in a way single touch screens do it.");
        }

        public override void onPressAndHold(Touch touch)
        {
            Console.WriteLine("Processes a press and hold touch in a way single touch screens do it.");
        }

        public override void onScroll(Touch touch)
        {
            Console.WriteLine("Processes a scroll touch in a way single touch screens do it.");
        }

        public override void onFlick(Touch touch)
        {
            Console.WriteLine("Processes a flick touch in a way single touch screens do it.");
        }
    }
}

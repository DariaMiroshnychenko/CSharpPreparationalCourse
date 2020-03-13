using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class MultiTouch : TouchBase
    {
        public MultiTouch() : base()
        {

        }

        public MultiTouch(TouchTechnologies technology) : base(technology)
        {

        }

        public override void onSingleTap(Touch touch)
        {
            Console.WriteLine("Processes a single tap in a way multi-touch screens do it.");
        }

        public void onSingleTap(Touch[] touches)
        {
            Console.WriteLine("Processes a single tap by multiple fingers in a way multi-touch screens do it.");
        }

        public override void onDoubleTap(Touch touch)
        {
            Console.WriteLine("Processes a double tap in a way multi-touch screens do it.");
        }

        public void onDoubleTap(Touch[] touches)
        {
            Console.WriteLine("Processes a double tap by multiple fingers in a way multi-touch screens do it.");
        }

        public override void onPressAndHold(Touch touch)
        {
            Console.WriteLine("Processes a press and hold touch in a way multi-touch screens do it.");
        }

        public override void onScroll(Touch touch)
        {
            Console.WriteLine("Processes a scroll touch in a way multi-touch screens do it.");
        }

        public void onScroll(Touch[] touches)
        {
            Console.WriteLine("Processes a scroll touch by multiple fingers in a way multi-touch screens do it.");
        }

        public override void onFlick(Touch touch)
        {
            Console.WriteLine("Processes a flick touch in a way multi-touch screens do it.");
        }

        public void onFlick(Touch[] touches)
        {
            Console.WriteLine("Processes a flick touch by multiple fingers in a way multi-touch screens do it.");
        }

        public void onPinch(Touch[] touches)
        {
            Console.WriteLine("Processes a pinch touch by multiple fingers in a way multi-touch screens do it.");
        }
    }
}

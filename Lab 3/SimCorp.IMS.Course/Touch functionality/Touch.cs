using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Touch
    {
        public int TouchId { get; set; }
        public int ScreenX { get; set; }
        public int ScreenY { get; set; }
        public double Force { get; set; }
        public double Duration { get; set; }
        public string TargetElement { get; set; }

        public Touch() : this(touchId: 0, screenX: 0, screenY: 0, force: 0, duration: 0, targetElement: "")
        {

        }

        public Touch(int touchId, int screenX, int screenY, float force, float duration, string targetElement)
        {
            this.TouchId = touchId;
            this.ScreenX = screenX;
            this.ScreenY = screenY;
            this.Force = force;
            this.Duration = duration;
            this.TargetElement = targetElement;
        }
    }
}

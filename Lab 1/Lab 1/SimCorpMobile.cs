using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SimCorpMobile : MobilePhone
    {
        public override ScreenBase Screen { get { return vLCDScreen; } }
        private readonly LCDScreen vLCDScreen = new LCDScreen();

        public override Battery Battery { get { return vBattery; } }
        private readonly Battery vBattery = new Battery();

        public override Keyboard Keyboard { get { return vKeyboard; } }
        private readonly Keyboard vKeyboard = new Keyboard();

        public override TouchBase TouchScreenFunctionality { get { return vTouchScreenFunctionality; } }
        private readonly TouchBase vTouchScreenFunctionality = new MultiTouch();

        public override MicrophoneBase Microphone { get { return vMEMSMicrophone; } }
        private readonly MEMSMicrophone vMEMSMicrophone = new MEMSMicrophone();

        public override CameraBase Camera { get { return vDualRearCamera; } }
        private readonly DualRearCamera vDualRearCamera = new DualRearCamera();

        public override Processor CPU { get { return vCPU; } }
        private readonly Processor vCPU = new Processor();

        public override InternalStorage InternalStorage { get { return vInternalStorage; } }
        private readonly InternalStorage vInternalStorage = new InternalStorage();

        public override RemovableStorage RemovableStorage { get { return vRemovableStorage; } }
        private readonly RemovableStorage vRemovableStorage = new RemovableStorage();

        public override Software Software { get { return vSoftware; } }
        private readonly Software vSoftware = new Software();

        public override Network Network { get { return vNetwork; } }
        private readonly Network vNetwork = new Network();

        public override Connectivity Connectivity { get { return vConnectivity; } }
        private readonly Connectivity vConnectivity = new Connectivity();
    }
}

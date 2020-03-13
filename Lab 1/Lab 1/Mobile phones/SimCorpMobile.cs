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
        private readonly LCDScreenColorful vLCDScreen;

        public override Battery Battery { get { return vBattery; } }
        private readonly Battery vBattery;

        public override Keyboard Keyboard { get { return vKeyboard; } }
        private readonly Keyboard vKeyboard;

        public override TouchBase TouchScreenFunctionality { get { return vTouchScreenFunctionality; } }
        private readonly TouchBase vTouchScreenFunctionality;

        public override MicrophoneBase Microphone { get { return vMEMSMicrophone; } }
        private readonly MEMSMicrophone vMEMSMicrophone;

        public override CameraBase Camera { get { return vDualRearCamera; } }
        private readonly DualRearCamera vDualRearCamera;

        public override Processor CPU { get { return vCPU; } }
        private readonly Processor vCPU;

        public override InternalStorage InternalStorage { get { return vInternalStorage; } }
        private readonly InternalStorage vInternalStorage;

        public override RemovableStorage RemovableStorage { get { return vRemovableStorage; } }
        private readonly RemovableStorage vRemovableStorage;

        public override Software Software { get { return vSoftware; } }
        private readonly Software vSoftware;

        public override Network Network { get { return vNetwork; } }
        private readonly Network vNetwork;

        public override Connectivity Connectivity { get { return vConnectivity; } }
        private readonly Connectivity vConnectivity;

        public SimCorpMobile() : this(screen: new LCDScreenColorful(),
                                      battery: new Battery(),
                                      keyboard: new Keyboard(),
                                      multiTouchFunctionality: new MultiTouch(),
                                      memsMicrophone: new MEMSMicrophone(),
                                      dualRearCamera: new DualRearCamera(),
                                      cpu: new Processor(),
                                      internalStorage: new InternalStorage(),
                                      removableStorage: new RemovableStorage(),
                                      software: new Software(),
                                      network: new Network(),
                                      connectivity: new Connectivity())
        {

        }

        public SimCorpMobile(LCDScreenColorful screen,
                             Battery battery, 
                             Keyboard keyboard, 
                             MultiTouch multiTouchFunctionality, 
                             MEMSMicrophone memsMicrophone, 
                             DualRearCamera dualRearCamera, 
                             Processor cpu, 
                             InternalStorage internalStorage,
                             RemovableStorage removableStorage,
                             Software software,
                             Network network,
                             Connectivity connectivity)
        {
            this.vLCDScreen = screen;
            this.vBattery = battery;
            this.vKeyboard = keyboard;
            this.vTouchScreenFunctionality = multiTouchFunctionality;
            this.vMEMSMicrophone = memsMicrophone;
            this.vDualRearCamera = dualRearCamera;
            this.vCPU = cpu;
            this.vInternalStorage = internalStorage;
            this.vRemovableStorage = removableStorage;
            this.vSoftware = software;
            this.vNetwork = network;
            this.vConnectivity = connectivity; 
        }
    }
}

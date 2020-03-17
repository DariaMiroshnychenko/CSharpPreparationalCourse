using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class MEMSMicrophone : MicrophoneBase
    {
        public enum MEMSDirectionalities
        {
            Omnidirectional,
            Bidirectional,
            Cardioid,
            SubCardioid,
            HyperCardioid,
            Shotgun
        }
        public MEMSDirectionalities Directionality { get; set; }

        public MEMSMicrophone() : this(directionality: MEMSDirectionalities.Omnidirectional,
                                       dynamicRange: 60,
                                       frequencyResponce: new int[] { 300, 3200 },
                                       sensitivity: -26,
                                       signalToNoiseRatio: 60)
        {

        }

        public MEMSMicrophone(MEMSDirectionalities directionality, int dynamicRange, int[] frequencyResponce, int sensitivity, int signalToNoiseRatio)
        {
            this.Directionality = directionality;
            this.DynamicRange = dynamicRange;
            this.FrequencyResponce = frequencyResponce;
            this.Sensitivity = sensitivity;
            this.SignalToNoiseRatio = signalToNoiseRatio;
        }

        public override void ProcessSound()
        {
            // processes sound in a manner Micro-Electro-Mechanical System Microphones do
        }

        public override string ToString()
        {
            return "Micro-Electro-Mechanical System Microphone";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class ECMicrophone : MicrophoneBase
    {
        public enum ECMDirectionalities
        {
            Omnidirectional,
            Unidirectional,
            NoiseCancelling
        }

        public enum ECMTypes
        {
            Pin,
            Terminal,
            Wire
        }

        public ECMDirectionalities Directionality { get; set; }
        public ECMTypes Type { get; set; }
        public ECMicrophone() : this(directionality: ECMDirectionalities.Omnidirectional, 
                                     type: ECMTypes.Pin, 
                                     dynamicRange: 50,
                                     frequencyResponce: new int[] { 300, 3000 },
                                     sensitivity: -24,
                                     signalToNoiseRatio: 65)
        {

        }
        public ECMicrophone(ECMDirectionalities directionality, ECMTypes type, int dynamicRange, int[] frequencyResponce, int sensitivity, int signalToNoiseRatio)
        {
            this.Directionality = directionality;
            this.Type = type;
            this.DynamicRange = dynamicRange;
            this.FrequencyResponce = frequencyResponce;
            this.Sensitivity = sensitivity;
        }
        public override void ProcessSound()
        {
            // processes a sound in a manner Electret Concender Microphones do
        }
        public override string ToString()
        {
            return "Electret Concender Microphone";
        }
    }
}

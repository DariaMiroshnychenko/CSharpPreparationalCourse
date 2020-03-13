using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class MicrophoneBase
    {
        public int DynamicRange { get; set; } // in dB
        public int[] vFrequencyResponse;
        public int[] FrequencyResponce    // in Hz
        {
            get
            {
                return vFrequencyResponse;
            }
            set
            {
                if (value.Count() != 2)
                {
                    Console.WriteLine("Frequency response of a microphone should contain 2 numbers that represent a range of sound that a microphone can reproduce.");
                }
                else if ((value[0] < 0) || (value[1] < 0))
                {
                    Console.WriteLine("Both numbers in a frequency response should be positive.");
                }
                else
                {
                    vFrequencyResponse = value;
                }
            } 
        }

        public int Sensitivity { get; set; } // in dB
        public int SignalToNoiseRatio { get; set; } // in dBA

        public abstract void ProcessSound();
    }
}

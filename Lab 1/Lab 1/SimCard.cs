using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SimCard
    {
        public enum SimCardTypes
        {
            fullSizeSIM,
            miniSIM,
            microSIM,
            nanoSIM,
            eSIM
        }

        public SimCardTypes Type { get; set; }
        public int[] vPIN;
        public int[] PIN
        {
            get
            {
                return vPIN;
            }
            set
            {
                if (value.Count() < 4)
                {
                    Console.WriteLine("A code must contain exactly 4 digits.");
                }
                else
                {
                    vPIN = value;
                }
            }
        }
        public int[] vPUK;
        public int[] PUK
        {
            get
            {
                return vPUK;
            }
            set
            {
                if (value.Count() < 4)
                {
                    Console.WriteLine("A code must contain exactly 4 digits.");
                }
                else
                {
                    vPUK = value;
                }
            }
        }


        public SimCard() : this(simCardType: SimCardTypes.microSIM, pin: new int[] { 0, 0, 0, 0 }, puk: new int[] { 1, 1, 1, 1 })
        {

        }

        public SimCard(SimCardTypes simCardType, int[] pin, int[] puk)
        {
            this.Type = simCardType;
            this.PIN = pin;
            this.PUK = puk;
        }

        public void AuthenticateSubscriber()
        {
            // logic that authenticates a sucsriber by PIN (or PUK)
        }

        public void ChangePIN()
        {
            // logic of changing a PIN code
        }

        public override string ToString()
        {
            return Type + " card";
        }
    }
}

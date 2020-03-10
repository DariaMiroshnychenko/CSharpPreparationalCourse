using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Network
    {
        public enum NetworkSpeeds
        {
            SecondG,
            ThirdG,
            FourthG
        }

        public enum NetworkBands
        {
            GSM,
            UMTS,
            LTE,
            WCDMA
        }

        public NetworkSpeeds[] Speeds { get; set; }
        public NetworkBands[] Bands { get; set; }
        public SimCard[] SimCards { get; set; }

        public Network() : this(bands: new NetworkBands[] { NetworkBands.GSM, NetworkBands.LTE },
                                speeds: new NetworkSpeeds[] { NetworkSpeeds.SecondG, NetworkSpeeds.ThirdG, NetworkSpeeds.FourthG },
                                simCards: new SimCard[] { new SimCard() })
        {

        }

        public Network(NetworkBands[] bands, NetworkSpeeds[] speeds, SimCard[] simCards)
        {
            this.Bands = bands;
            this.Speeds = speeds;
            this.SimCards = simCards;
        }

        public override string ToString()
        {
            string bands = "supported bands: ";
            foreach (NetworkBands Band in Bands)
            {
                bands += Band + ", ";
            }

            string speeds = "supported speeds: ";
            foreach (NetworkSpeeds Speed in Speeds)
            {
                switch (Speed)
                {
                    case NetworkSpeeds.SecondG:
                        speeds += "2G, ";
                        break;
                    case NetworkSpeeds.ThirdG:
                        speeds += "3G, ";
                        break;
                    case NetworkSpeeds.FourthG:
                        speeds += "4G, ";
                        break;
                    default:
                        break;
                }
            }

            string simCards = "SIM card: " + SimCards.Count() + " slot(s) of type(s) ";
            foreach (SimCard SimCard in SimCards)
            {
                simCards += SimCard.Type + " ";
            }

            return bands + speeds + simCards;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class SimCardHandler
    {
        public enum SimCardTypes
        {
            KyivstarSimCard = 1,
            LifecellSimCard = 2,
            VodafoneSimCard = 3
        }

        IOutput Output;

        public SimCardHandler(IOutput output)
        {
            this.Output = output;
        }

        public SimCardTypes GetSimCardType(string enteredSimCardTypeIndex)
        {
            int simCardTypeIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredSimCardTypeIndex)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredSimCardTypeIndex, out simCardTypeIndex)) throw new ArgumentException("Index must be numeric.");


            int numberOfAvailableSimCardTypes = Enum.GetValues(typeof(SimCardTypes)).Length;
            if ((simCardTypeIndex < 1) || (simCardTypeIndex > numberOfAvailableSimCardTypes))
            {
                throw new ArgumentOutOfRangeException(paramName: "simCardTypeIndex", message: "Entered index is out of the available range.");
            }

            return (SimCardTypes)simCardTypeIndex;
        }

        public ISimCard GetSimCard(SimCardTypes simCardType)
        {
            ISimCard simCard = null;

            switch (simCardType)
            {
                case SimCardTypes.KyivstarSimCard:
                    simCard = new KyivstarSimCard(Output);
                    Output.WriteLine($"{nameof(KyivstarSimCard)} selected");
                    break;
                case SimCardTypes.LifecellSimCard:
                    simCard = new LifecellSimCard(Output);
                    Output.WriteLine($"{nameof(LifecellSimCard)} selected");
                    break;
                case SimCardTypes.VodafoneSimCard:
                    simCard = new VodafoneSimCard(Output);
                    Output.WriteLine($"{nameof(VodafoneSimCard)} selected");
                    break;
            }

            return simCard;
        }

        public void SetAndConnectSimCard(SimCorpMobile simCorpMobile, ISimCard simCard)
        {
            simCorpMobile.SimCard = simCard;
            simCorpMobile.ConnectToLocalMobileNetwork();
        }

        public void ShowMenuOfSimCards()
        {
            var menuBuilder = new StringBuilder();

            menuBuilder.AppendLine("Select SIM card by specifying its index:");

            string[] simCardTypes = Enum.GetNames(typeof(SimCardTypes));
            for (int i = 0; i < simCardTypes.Count(); i++)
            {
                menuBuilder.AppendLine($"{i + 1} - {simCardTypes[i]}");
            }

            Output.Write(menuBuilder.ToString());
        }
    }
}

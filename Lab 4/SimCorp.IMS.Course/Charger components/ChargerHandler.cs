using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class ChargerHandler
    {
        public enum ChargerComponentTypes
        {
            OwnCharger = 1,
            NokiaCharger = 2,
            HuaweiPowerBank = 3,
            NomiPowerBank = 4,
            QQEERSolarPowerBank = 5
        }

        IOutput Output;

        public ChargerHandler(IOutput output)
        {
            this.Output = output;
        }

        public ChargerComponentTypes GetChargerType(string enteredChargerTypeIndex)
        {
            int chargerTypeIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredChargerTypeIndex)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredChargerTypeIndex, out chargerTypeIndex)) throw new ArgumentException("Index must be numeric.");


            int numberOfAvailableChargerTypes = Enum.GetValues(typeof(ChargerComponentTypes)).Length;
            if ((chargerTypeIndex < 1) || (chargerTypeIndex > numberOfAvailableChargerTypes))
            {
                throw new ArgumentOutOfRangeException(paramName: "chargerTypeIndex", message: "Entered index is out of the available range.");
            }

            return (ChargerComponentTypes)chargerTypeIndex;
        }

        public ICharger GetCharger(ChargerComponentTypes chargerType)
        {
            ICharger chargerComponent = null;

            switch (chargerType)
            {
                case ChargerComponentTypes.OwnCharger:
                    chargerComponent = new OwnCharger(Output);
                    Output.WriteLine($"{nameof(OwnCharger)} selected");
                    break;
                case ChargerComponentTypes.NokiaCharger:
                    chargerComponent = new NokiaCharger(Output);
                    Output.WriteLine($"{nameof(NokiaCharger)} selected");
                    break;
                case ChargerComponentTypes.HuaweiPowerBank:
                    chargerComponent = new HuaweiPowerBank(Output);
                    Output.WriteLine($"{nameof(HuaweiPowerBank)} selected");
                    break;
                case ChargerComponentTypes.NomiPowerBank:
                    chargerComponent = new NomiPowerBank(Output);
                    Output.WriteLine($"{nameof(NomiPowerBank)} selected");
                    break;
                case ChargerComponentTypes.QQEERSolarPowerBank:
                    chargerComponent = new QQEERSolarPowerBank(Output);
                    Output.WriteLine($"{nameof(QQEERSolarPowerBank)} selected");
                    break;
            }

            return chargerComponent;
        }

        public void SetAndRunCharger(SimCorpMobile simCorpMobile, ICharger chargerComponent)
        {
            simCorpMobile.Charger = chargerComponent;
            simCorpMobile.Charge();
        }

        public void ShowMenuOfChargerComponents()
        {
            var menuBuilder = new StringBuilder();

            menuBuilder.AppendLine("Select charger component by specifying its index:");

            string[] chargerTypes = Enum.GetNames(typeof(ChargerComponentTypes));
            for (int i = 0; i < chargerTypes.Count(); i++)
            {
                menuBuilder.AppendLine($"{i + 1} - {chargerTypes[i]}");
            }

            Output.Write(menuBuilder.ToString());
        }
    }
}

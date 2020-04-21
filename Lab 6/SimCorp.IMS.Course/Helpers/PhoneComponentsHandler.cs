using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimCorp.IMS.Course.ChargerHandler;
using static SimCorp.IMS.Course.PlaybackHandler;
using static SimCorp.IMS.Course.SimCardHandler;
using static SimCorp.IMS.Course.StorageHandler;

namespace SimCorp.IMS.Course
{
    public class PhoneComponentsHandler
    {
        IOutput Output { get; set; }
        IInput Input { get; set;}

        public PhoneComponentsHandler(IOutput output, IInput input)
        {
            this.Output = output;
            this.Input = input;
        }

        public enum AvailableForSettingPhoneComponents
        {
            PlaybackComponent = 1,
            ChargerComponent = 2,
            StorageComponent = 3,
            SIMCard = 4
        }
        public void SelectAndSetComponents(SimCorpMobile simCorpMobile)
        {
            ShowMenuOfAvailableComponents();
            string enteredComponentTypeIndex = Input.ReadLine();

            try
            {
                AvailableForSettingPhoneComponents componentType = GetComponentType(enteredComponentTypeIndex);
                ComponentSetting(simCorpMobile, componentType);
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }

            ShowExitDialog();
            string enteredContinueIndication = Input.ReadLine();

            try
            {
                bool continueIndication = GetContinueIndication(enteredContinueIndication);
                if (continueIndication)
                {
                    SelectAndSetComponents(simCorpMobile);
                }
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }

        public bool GetContinueIndication(string enteredContinueIndication)
        {
            bool continueIndication = false;
            int continueIndicationIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredContinueIndication)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredContinueIndication, out continueIndicationIndex)) throw new ArgumentException("Index must be numeric.");

            if (continueIndicationIndex == 1)
            {
                continueIndication = true;
            }
            else if (continueIndicationIndex == 2)
            {
                Output.WriteLine("Press any key to close the program.");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Entered value is out of the available range.");
            }

            return continueIndication;
        }

        private void ShowExitDialog()
        {
            var dialogBuilder = new StringBuilder();

            dialogBuilder.AppendLine();
            dialogBuilder.AppendLine("Do you want to set another component to the phone?");
            dialogBuilder.AppendLine("1 - Yes");
            dialogBuilder.AppendLine("2 - No");

            Output.WriteLine(dialogBuilder.ToString());
        }

        public AvailableForSettingPhoneComponents GetComponentType(string enteredComponentTypeIndex)
        {
            int componentTypeIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredComponentTypeIndex)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredComponentTypeIndex, out componentTypeIndex)) throw new ArgumentException("Index must be numeric.");

            int numberOfAvailableComponents = Enum.GetValues(typeof(AvailableForSettingPhoneComponents)).Length;
            if ((componentTypeIndex < 1) || (componentTypeIndex > numberOfAvailableComponents))
            {
                throw new ArgumentOutOfRangeException(paramName: "componentTypeIndex", message: "Entered index is out of the available range.");
            }

            return (AvailableForSettingPhoneComponents)componentTypeIndex;
        }

        public void ComponentSetting(SimCorpMobile simCorpMobile, AvailableForSettingPhoneComponents component)
        {
            switch (component)
            {
                case AvailableForSettingPhoneComponents.PlaybackComponent:
                    ShowMenuOfPlaybacks();
                    GetAndProcessUserSelectionOfPlayback(simCorpMobile);
                    break;

                case AvailableForSettingPhoneComponents.ChargerComponent:
                    ShowMenuOfChargers();
                    GetAndProcessUserSelectionOfCharger(simCorpMobile);
                    break;

                case AvailableForSettingPhoneComponents.StorageComponent:
                    ShowMenuOfStorages();
                    GetAndProcessUserSelectionOfStorage(simCorpMobile);
                    break;

                case AvailableForSettingPhoneComponents.SIMCard:
                    ShowMenuOfSimCards();
                    GetAndProcessUserSelectionOfSimCard(simCorpMobile);
                    break;
            }
        }

        public void GetAndProcessUserSelectionOfSimCard(SimCorpMobile simCorpMobile)
        {
            SimCardHandler simCardHandler = new SimCardHandler(Output);

            string enteredSimCardTypeIndex = Input.ReadLine();

            try
            {
                SimCardTypes simCardType = simCardHandler.GetSimCardType(enteredSimCardTypeIndex);
                ISimCard simCardComponent = simCardHandler.GetSimCard(simCardType);
                simCardHandler.SetAndConnectSimCard(simCorpMobile, simCardComponent);
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }

        public void ShowMenuOfSimCards()
        {
            SimCardHandler simCardHandler = new SimCardHandler(Output);
            simCardHandler.ShowMenuOfSimCards();
        }

        public void GetAndProcessUserSelectionOfStorage(SimCorpMobile simCorpMobile)
        {
            StorageHandler storageHandler = new StorageHandler(Output);

            string enteredStorageTypeIndex = Input.ReadLine();

            try
            {
                StorageComponentTypes storageType = storageHandler.GetStorageType(enteredStorageTypeIndex);
                IStorage storageComponent = storageHandler.GetStorage(storageType);
                storageHandler.SetAndRunStorage(simCorpMobile, storageComponent);
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }

        public void ShowMenuOfStorages()
        {
            StorageHandler storageHandler = new StorageHandler(Output);
            storageHandler.ShowMenuOfStorages();
        }

        public void GetAndProcessUserSelectionOfCharger(SimCorpMobile simCorpMobile)
        {
            ChargerHandler chargerHandler = new ChargerHandler(Output);

            string enteredChargerTypeIndex = Input.ReadLine();

            try
            {
                ChargerComponentTypes chargerType = chargerHandler.GetChargerType(enteredChargerTypeIndex);
                ICharger chargerComponent = chargerHandler.GetCharger(chargerType);
                chargerHandler.SetAndRunCharger(simCorpMobile, chargerComponent);

            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }

        public void ShowMenuOfChargers()
        {
            ChargerHandler chargerHandler = new ChargerHandler(Output);
            chargerHandler.ShowMenuOfChargerComponents();
        }

        public void GetAndProcessUserSelectionOfPlayback(SimCorpMobile simCorpMobile)
        {
            PlaybackHandler playbackHandler = new PlaybackHandler(Output);

            string enteredPlaybackTypeIndex = Input.ReadLine();

            try
            {
                PlaybackComponentTypes playbackTypeIndex = playbackHandler.GetPlaybackType(enteredPlaybackTypeIndex);
                IPlayback playbackComponent = playbackHandler.GetPlayback(playbackTypeIndex);
                playbackHandler.SetAndRunPlayback(simCorpMobile, playbackComponent);
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }

        public void ShowMenuOfPlaybacks()
        {
            PlaybackHandler playbackHandler = new PlaybackHandler(Output);
            playbackHandler.ShowMenuOfPlaybackComponents();
        }

        public void ShowMenuOfAvailableComponents()
        {
            var menuBuilder = new StringBuilder();

            menuBuilder.AppendLine("Select component which you would like to set to the phone.\nSpecify its index:");

            string[] availableComponents = Enum.GetNames(typeof(AvailableForSettingPhoneComponents));
            for (int i = 0; i < availableComponents.Count(); i++)
            {
                menuBuilder.AppendLine($"{i + 1} - {availableComponents[i]}");
            }

            Output.WriteLine(menuBuilder.ToString());
        }
    }
}

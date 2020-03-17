using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public abstract class MobilePhone
    {
        public abstract ScreenBase Screen { get; }
        public abstract Battery Battery { get; }
        public abstract Keyboard Keyboard { get; }
        public abstract TouchBase TouchScreenFunctionality { get; }
        public abstract MicrophoneBase Microphone { get; }
        public abstract CameraBase Camera { get; }
        public abstract Processor CPU { get; }
        public abstract InternalStorage InternalStorage { get; }
        public abstract Software Software { get; }
        public abstract Network Network { get; }
        public abstract Connectivity Connectivity { get; }
        public IOutput Output { get; set; }
        private IPlayback vPlaybackComponent;
        public IPlayback PlaybackComponent
        {
            get
            {
                return vPlaybackComponent;
            }
            set
            {
                Output.WriteLine("Setting the playback component to the phone...");
                vPlaybackComponent = value;
            }
        }
        private ICharger vCharger;
        public ICharger Charger
        {
            get
            {
                return vCharger;
            }
            set
            {
                Output.WriteLine("Setting the charger to the phone...");
                vCharger = value;
            }
        }
        private IStorage vRemovableStorage;
        public IStorage RemovableStorage
        {
            get
            {
                return vRemovableStorage;
            }
            set
            {
                Output.WriteLine("Setting the removable storage to the phone...");
                vRemovableStorage = value;
            }
        }
        private ISimCard vSimCard;
        public ISimCard SimCard
        {
            get
            {
                return vSimCard;
            }
            set
            {
                Output.WriteLine("Setting the SIM card to the phone...");
                vSimCard = value;
            }
        }

        public void ConnectToLocalMobileNetwork()
        {
            Output.WriteLine("Connect to the local mobile network:");
            SimCard.ConnectToLocalMobileNetwork();
        }

        public void SendTextMessage(string message, int[] phoneNumber)
        {
            Output.WriteLine($"Send the message {message} to a number {phoneNumber}:");
            SimCard.SendTextMessage(message, phoneNumber);
        }

        public void PlaceCall(int[] phoneNumber)
        {
            Output.WriteLine($"Place a call to the number {phoneNumber}:");
            SimCard.PlaceCall(phoneNumber);
        }

        public void StoreToRemovableStorage(Object data)
        {
            Output.WriteLine("Store the data to the removable storage:");
            RemovableStorage.Store(data);
        }
        public void Charge()
        {
            Output.WriteLine("Charge the phone:");
            Charger.Charge();
        }

        public void Play(Object sound)
        {
            Output.WriteLine("Play sound on the phone:");
            PlaybackComponent.Play(sound);
        }

        public void ShowImage(IScreenImage screenImage)
        {
            Screen.ShowImage(screenImage);
        }
        public void ShowImage(IScreenImage screenImage, int brightness)
        {
            Screen.ShowImage(screenImage, brightness);
        }
        public void TakePhoto()
        {
            Camera.TakePhoto();
        }
        public void ProcessSoundIntoAudio()
        {
            Microphone.ProcessSound();
        }

        public void InformAboutLowRemainingCharge()
        {
            string messageToShow = Battery.GiveAWarningAboutLowRemainingCharge();
            if (!String.IsNullOrEmpty(messageToShow))
            {
                Output.WriteLine(messageToShow);
            }
        }

        public void GoIntoPowerSavingMode()
        {
            if (Battery.IsEmpty())
            {
                CPU.GoIntoPowerSavingMode();
            }
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();

            descriptionBuilder.AppendLine($"Screen type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard type: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Touchscreen: {TouchScreenFunctionality.ToString()}");
            descriptionBuilder.AppendLine($"Microphone type: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Camera: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Processor: {CPU.ToString()}");
            descriptionBuilder.AppendLine($"Internal storage: {InternalStorage.ToString()}");
            descriptionBuilder.AppendLine($"Removable storage: {RemovableStorage.ToString()}");
            descriptionBuilder.AppendLine($"Software: {Software.ToString()}");
            descriptionBuilder.AppendLine($"Network: {Network.ToString()}");
            descriptionBuilder.AppendLine($"Connectivity: {Connectivity.ToString()}");

            return descriptionBuilder.ToString();
        }
    }
}

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
        public abstract RemovableStorage RemovableStorage { get; }
        public abstract Software Software { get; }
        public abstract Network Network { get; }
        public abstract Connectivity Connectivity { get; }

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

        public void Charge()
        {
            Battery.Charge();
        }

        public void InformAboutLowRemainingCharge()
        {
            string messageToShow = Battery.GiveAWarningAboutLowRemainingCharge();
            if (!String.IsNullOrEmpty(messageToShow))
            {
                Console.WriteLine(messageToShow);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class PlaybackHandler
    {
        public enum PlaybackComponentTypes
        {
            iPhoneHeadset = 1,
            UnofficialiPhoneHeadset = 2,
            SamsungHeadset = 3,
            PhoneSpeaker = 4
        }

        IOutput Output;

        public PlaybackHandler(IOutput output)
        {
            this.Output = output;
        }

        public PlaybackComponentTypes GetPlaybackType(string enteredPlaybackTypeIndex)
        {
            int playbackTypeIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredPlaybackTypeIndex)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredPlaybackTypeIndex, out playbackTypeIndex)) throw new ArgumentException("Index must be numeric.");


            int numberOfAvailablePlaybackTypes = Enum.GetValues(typeof(PlaybackComponentTypes)).Length;
            if ((playbackTypeIndex < 1) || (playbackTypeIndex > numberOfAvailablePlaybackTypes))
            {
                throw new ArgumentOutOfRangeException(paramName: "playbackTypeIndex", message: "Entered index is out of the available range.");
            }

            return (PlaybackComponentTypes)playbackTypeIndex;
        }

        public IPlayback GetPlayback(PlaybackComponentTypes playbackType)
        {
            IPlayback playbackComponent = null;

            switch (playbackType)
            {
                case PlaybackComponentTypes.iPhoneHeadset:
                    playbackComponent = new iPhoneHeadset(Output);
                    Output.WriteLine($"{nameof(iPhoneHeadset)} selected");
                    break;
                case PlaybackComponentTypes.UnofficialiPhoneHeadset:
                    playbackComponent = new UnofficialiPhoneHeadset(Output);
                    Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} selected");
                    break;
                case PlaybackComponentTypes.SamsungHeadset:
                    playbackComponent = new SamsungHeadset(Output);
                    Output.WriteLine($"{nameof(SamsungHeadset)} selected");
                    break;
                case PlaybackComponentTypes.PhoneSpeaker:
                    playbackComponent = new PhoneSpeaker(Output);
                    Output.WriteLine($"{nameof(PhoneSpeaker)} selected");
                    break;
            }

            return playbackComponent;
        }

        public void SetAndRunPlayback(SimCorpMobile simCorpMobile, IPlayback playbackComponent)
        {
            simCorpMobile.PlaybackComponent = playbackComponent;
            Object Sound = new Object();
            simCorpMobile.Play(Sound);
        }

        public void ShowMenuOfPlaybackComponents()
        {
            var menuBuilder = new StringBuilder();
        
            menuBuilder.AppendLine("Select playback component by specifying its index:");

            string[] playbackTypes = Enum.GetNames(typeof(PlaybackComponentTypes));
            for (int i = 0; i < playbackTypes.Count(); i++)
            {
                menuBuilder.AppendLine($"{i + 1} - {playbackTypes[i]}");
            }

            Output.Write(menuBuilder.ToString());
        }
    }
}

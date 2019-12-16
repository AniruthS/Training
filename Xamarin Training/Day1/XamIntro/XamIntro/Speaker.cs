using System;
namespace XamIntro
{
    public class Speaker
    {
        public string SpeakerName { get; set; }
        public string Topic { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return $"{Topic} - ({SpeakerName})";
        }
    }
}

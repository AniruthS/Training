using System;
using System.Collections.Generic;

namespace XamIntro
{
    public class SpeakerService
    {
        public List<Speaker> GetSpeakers()
        {
            return new List<Speaker>()
            {
                new Speaker()
                {
                    SpeakerName = "Mahesh Chand",
                    Topic = "Keynote",
                    ImageUrl="https://pbs.twimg.com/profile_images/713370773134532608/IrJ2F6o-_400x400.jpg"
                },
                new Speaker()
                {
                    SpeakerName = "Pinal Dave",
                    Topic = "Best Practices of SQL Server",
                    ImageUrl="https://pluralsight.imgix.net/author/lg/pinal-dave-v1.jpg"
                },
                new Speaker()
                {
                    SpeakerName = "Sekhar Srinivasan",
                    Topic = "Data Visualization using Tableau",
                    ImageUrl="https://pluralsight.imgix.net/author/lg/sekhar-srinivas-v3.jpg"
                }
            };
        }
    }
}

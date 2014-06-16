using System;

namespace FootballTournament2014.Common.Models
{
    public class Podcast : BaseModel
    {
        public Podcast()
        {
        }

        public string Url
        {
            get;
            set;
        }
        public string PublishDate
        {
            get;
            set;
        }
        public string PodMp3Url
        {
            get;
            set;
        }
    }
}


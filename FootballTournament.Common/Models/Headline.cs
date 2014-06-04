using System;

namespace FootballTournament2014.Common.Models
{
    public class Headline : BaseModel
    {
        public Headline()
        {
        }
        public Links links { get; set; }
        public string headline { get; set; }

        public string Description
        {
            get;
            set;
        }
        public string Url
        {
            get{ return links.web.href.ToString(); }
        }
    }
}


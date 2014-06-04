using System;

namespace FootballTournament2014.Common.Models
{
    public class Web
    {
        public string href { get; set; }
        public Teams teams {get;set;}
    }
    public class Teams {
        public string href {get;set;}
    }
    public class Mobile
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Web web { get; set; }
        public Mobile mobile { get; set; }
    }
}


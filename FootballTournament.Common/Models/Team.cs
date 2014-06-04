using System;
using System.Collections.Generic;

namespace FootballTournament2014.Common.Models
{
    public class Team : BaseModel
    {
        public Team()
        {
        }

        public string Name
        {
            get;
            set;
        }
        public Links Links { get; set; }
        public string Abbreviation { get; set; }
        public string FirstLetter { get { return Name.Substring(0, 1); } }
    }
  
    public class League
    {
        public List<Team> teams { get; set; }
    }
    public class TeamsResult
    {
            public List<Sport> sports { get; set; }
    }
    public class Sport
    {
        public List<League> leagues { get; set; }
    }
}


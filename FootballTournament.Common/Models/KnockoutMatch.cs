using System;

namespace FootballTournament2014.Common.Models
{
    public class KnockoutMatch : Match
    {
        public KnockoutMatch(string knockoutMatchName)
        {
        }

        public string KnockoutMatchName
        {
            get;
            private set;
        }

        public string KnockoutMatchDate
        {
            get { return base.MatchDate; }
        }
    }
}


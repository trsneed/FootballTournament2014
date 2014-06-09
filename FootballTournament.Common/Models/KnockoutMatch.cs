using System;

namespace FootballTournament2014.Common.Models
{
    public class KnockoutMatch : Match
    {
        public KnockoutMatch(string knockoutMatchName)
        {
            KnockoutMatchName = knockoutMatchName;
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

        public string KnockoutMatchTeams
        {
            get{
                return String.Format("{0} vs. {1}", this.HomeTeam, this.AwayTeam);
            }
        }
    }
}


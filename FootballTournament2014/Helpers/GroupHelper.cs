using System;
using System.Collections.ObjectModel;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class GroupHelper : ObservableCollection<Match>
    {
        public GroupHelper (string date)
        {
            Date = date;
        }

        public string Date
        {
            get;
            private set;
        }
    }
}


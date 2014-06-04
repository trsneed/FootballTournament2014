using System;
using System.Collections.Generic;

namespace FootballTournament2014.Common.Models
{
    internal class SearchResults
    {
        public SearchResults()
        {
        }

            public string timestamp { get; set; }
            public int resultsOffset { get; set; }
            public string status { get; set; }
            public int resultsLimit { get; set; }
            public int resultsCount { get; set; }
            public List<Headline> headlines { get; set; }
        

    }
}


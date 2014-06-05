using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FootballTournament2014.Common.Models;
using System.Linq;

namespace FootballTournament2014.Common.Services
{
    public static class MatchService
    {
        public static List<Match> GetMatchDay(string json)
        {
            var matchDay = JsonConvert.DeserializeObject<MatchDay>(json);

            return matchDay.Matches;
        }
    }
}


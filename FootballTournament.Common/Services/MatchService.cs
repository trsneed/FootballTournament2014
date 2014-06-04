using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014.Common.Services
{
    public static class MatchService
    {
        public static MatchDay GetMatchDay(string json)
        {
            return JsonConvert.DeserializeObject<MatchDay>(json);
        }
    }
}


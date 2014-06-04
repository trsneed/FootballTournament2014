using System;
using System.Collections.Generic;
using FootballTournament2014.Common.Models;
using Newtonsoft.Json;

namespace FootballTournament2014.Common.Services
{
    public static class TeamsService
    {
        public static List<Team> GetTeams(string json)
        {
            var result = JsonConvert.DeserializeObject<TeamsResult>(json);
            return result.sports[0].leagues[0].teams;
        }
    }
}


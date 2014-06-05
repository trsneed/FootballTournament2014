using System;
using FootballTournament2014.Common.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FootballTournament2014.Common.Models
{
    public class Match : BaseModel
    {
        public Match()
        {
        }
        [JsonProperty(PropertyName="team1_title")]
        public string HomeTeam {get;set;}
        [JsonProperty(PropertyName="team2_title")]
        public string AwayTeam {get;set;}
        [JsonProperty(PropertyName="score1")]
        public string HomeScore {get;set;}
        [JsonProperty(PropertyName="score2")]
        public string HomeScoreOT {get;set;}
        [JsonProperty(PropertyName="score1ot")]
        public string AwayScore {get;set;}
        [JsonProperty(PropertyName="score2ot")]
        public string AwayScoreOT {get;set;}
        [JsonProperty(PropertyName="score1p")]
        public string HomeScorePen {get;set;}
        [JsonProperty(PropertyName="score2p")]
        public string AwayScorePen {get;set;}
        [JsonProperty(PropertyName="play_at")]
        public string MatchDate { get; set; }

    }

    public class Round : BaseModel
    {
        public int pos { get; set; }
        public string start_at { get; set; }
        public string end_at { get; set; }
    }

    public class MatchDay
    {
        public Round Round { get; set; }
        [JsonProperty(PropertyName="games")]
        public List<Match> Matches { get; set; }
    }
}


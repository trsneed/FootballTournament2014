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
        public int? HomeScore {get;set;}
        [JsonProperty(PropertyName="score2")]
        public int? HomeScoreOT {get;set;}
        [JsonProperty(PropertyName="score1ot")]
        public int? AwayScore {get;set;}
        [JsonProperty(PropertyName="score2ot")]
        public int? AwayScoreOT {get;set;}
        [JsonProperty(PropertyName="score1p")]
        public int? HomeScorePen {get;set;}
        [JsonProperty(PropertyName="score2p")]
        public int? AwayScorePen {get;set;}
        [JsonProperty(PropertyName="play_at")]
        public DateTime MatchDate { get; set; }

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


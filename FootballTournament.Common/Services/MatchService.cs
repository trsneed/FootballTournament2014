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

        public static List<KnockoutMatch> GetKnockoutMatches()
        {
            var listOMatches = new List<KnockoutMatch>();
            listOMatches.Add(new KnockoutMatch("Round of 16 - 1"){ HomeTeam = "Winner Group A", AwayTeam = "Runner-up Group B",
                MatchDate = "2014/06/28"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 2"){ HomeTeam = "Winner Group C", AwayTeam = "Runner-up Group D",
                MatchDate = "2014/06/28"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 3"){ HomeTeam = "Winner Group E", AwayTeam = "Runner-up Group F",
                MatchDate = "2014/06/30" });
            listOMatches.Add(new KnockoutMatch("Round of 16 - 4"){ HomeTeam = "Winner Group G", AwayTeam = "Runner-up Group H",
                MatchDate = "2014/06/30"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 5"){ HomeTeam = "Winner Group B", AwayTeam = "Runner-up Group A",
                MatchDate = "2014/06/29"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 6"){ HomeTeam = "Winner Group D", AwayTeam = "Runner-up Group C",
                MatchDate = "2014/06/29"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 7"){ HomeTeam = "Winner Group F", AwayTeam = "Runner-up Group E",
                MatchDate = "2014/07/01"});
            listOMatches.Add(new KnockoutMatch("Round of 16 - 8"){ HomeTeam = "Winner Group H", AwayTeam = "Runner-up Group G",
                MatchDate = "2014/07/01"});
            listOMatches.Add(new KnockoutMatch("Quarter Final - 1"){ HomeTeam = "Round of 16 - 1", AwayTeam = "Round of 16 - 2",
                MatchDate = "2014/07/04"});
            listOMatches.Add(new KnockoutMatch("Quarter Final - 2"){ HomeTeam = "Round of 16 - 3", AwayTeam = "Round of 16 - 4",
                MatchDate = "2014/07/04"});
            listOMatches.Add(new KnockoutMatch("Quarter Final - 3"){ HomeTeam = "Round of 16 - 5", AwayTeam = "Round of 16 - 6",
                MatchDate = "2014/07/05"});
            listOMatches.Add(new KnockoutMatch("Quarter Final - 4"){ HomeTeam = "Round of 16 - 7", AwayTeam = "Round of 16 - 8",
                MatchDate = "2014/07/05"});
            listOMatches.Add(new KnockoutMatch("Semi Final - 1"){ HomeTeam = "Quarter Final - 1", AwayTeam = "Quarter Final - 2",
                MatchDate = "2014/07/08"});
            listOMatches.Add(new KnockoutMatch("Semi Final - 2"){ HomeTeam = "Quarter Final - 3", AwayTeam = "Quarter Final - 4",
                MatchDate = "2014/07/09"});
            listOMatches.Add(new KnockoutMatch("Third Place"){ HomeTeam = "Loser Semi Final - 1", AwayTeam = "Loser Semi Final - 2",
                MatchDate = "2014/07/12"});
            listOMatches.Add(new KnockoutMatch("Final"){ HomeTeam = "Semi Final - 1", AwayTeam = "Semi Final - 2",
                MatchDate = "2014/07/13"});

            return listOMatches;

        }
    }
}


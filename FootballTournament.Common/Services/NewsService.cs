using System;
using FootballTournament2014.Common.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FootballTournament2014.Common.Services
{
    public static class NewsService
    {
        public static List<Headline> GetNewsItems(string jsonResult)
        {
            var result = JsonConvert.DeserializeObject<SearchResults>(jsonResult);
            return result.headlines;
        }
    }
}


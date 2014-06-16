using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using FootballTournament2014.Common.Models;
using System.Collections.Generic;

namespace FootballTournament.Common.Services
{
    public static class PodcastService
    {
        public static List<Podcast> ParsePodcastRss(string rss)
        {
           
                var xdoc = XDocument.Parse(rss);
                var id = 0;
                return (from item in xdoc.Descendants("item")
                    select new Podcast
                {
                    Title = (string)item.Element("title"),
                    Details = (string)item.Element("description"),
                    Url = (string)item.Element("link"),
                    PublishDate = (string)item.Element("pubDate"),
                    Id = id++
                }).ToList();
        }


    }
}


using System;

namespace FootballTournament2014.Common.Models
{
    public enum MenuType
    {
        About,
        Blog,
        Twitter,
        Map,
        Groups,
        Knockout,
        News,
        Teams
    }
    public class MenuItem : BaseModel
    {
        public MenuItem ()
        {
            MenuType = MenuType.About;
        }
        public string Icon {get;set;}
        public MenuType MenuType { get; set; }
    }
}


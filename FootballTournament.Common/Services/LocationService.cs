using System;
using FootballTournament2014.Common.Models;
using System.Collections.Generic;

namespace FootballTournament2014.Common.Services
{
    public static class LocationService
    {
        public static List<Location> GetLocations()
        {
            return new List<Location>
            {
                new Location()
                {
                    Title = "Estádio do Maracanã",
                    City = "Rio de Janeiro",
                    Latitude = -22.912167,
                    Longitude = -43.230164,
                    Url = "http://en.wikipedia.org/wiki/Est%C3%A1dio_do_Maracan%C3%A3",
                },
                new Location()
                {
                    Title = "Estádio Nacional de Brasília Mané Garrincha",
                    City = "Brasília",
                    Latitude = -15.7835, 
                    Longitude = -47.899164,
                    Url = "http://en.wikipedia.org/wiki/Est%C3%A1dio_Nacional_Man%C3%A9_Garrincha",
                },
                new Location()
                {
                    Title = "Arena de São Paulo",
                    City = "São Paulo",
                    Latitude = -23.545531, 
                    Longitude = -46.473372,
                    Url = "http://en.wikipedia.org/wiki/Arena_de_S%C3%A3o_Paulo",
                },
                new Location()
                {
                    Title = "Estádio Castelão",
                    City = "Fortaleza",
                    Latitude = -3.807267, 
                    Longitude = -38.522481,
                    Url = "http://en.wikipedia.org/wiki/Castel%C3%A3o_(Cear%C3%A1)",
                },
                new Location()
                {
                    Title = "Estádio Mineirão",
                    City = "Belo Horizonte",
                    Latitude = -19.865833, 
                    Longitude = -43.970833,
                    Url = "http://en.wikipedia.org/wiki/Mineir%C3%A3o",
                },
                new Location()
                {
                    Title = "Estádio Beira-Rio",
                    City = "Porto Alegre",
                    Latitude = -30.065614, 
                    Longitude = -51.236086,
                    Url = "http://en.wikipedia.org/wiki/Est%C3%A1dio_Beira-Rio",
                },
                new Location()
                {
                    Title = "Arena Fonte Nova",
                    City = "Salvador",
                    Latitude = -12.978611, 
                    Longitude = -38.504167,
                    Url = "http://en.wikipedia.org/wiki/Itaipava_Arena_Fonte_Nova",
                },
                new Location()
                {
                    Title = "Arena Pernambuco",
                    City = "Recife",
                    Latitude = -8.04, 
                    Longitude = -35.008056,
                    Url = "http://en.wikipedia.org/wiki/Itaipava_Arena_Pernambuco",
                },
                new Location()
                {
                    Title = "Arena Pantanal",
                    City = "Cuiabá",
                    Latitude = -15.603056, 
                    Longitude = -56.120556,
                    Url = "http://en.wikipedia.org/wiki/Arena_Pantanal",
                },
                new Location()
                {
                    Title = "Arena da Amazônia",
                    City = "Manaus",
                    Latitude = -3.083056,
                    Longitude = -60.028056,
                    Url = "http://en.wikipedia.org/wiki/Arena_da_Amaz%C3%B4nia",
                },
                new Location()
                {
                    Title = "Arena das Dunas",
                    City = "Natal",
                    Latitude = -5.828939, 
                    Longitude = -35.213864,
                    Url = "http://en.wikipedia.org/wiki/Arena_das_Dunas",
                },
                new Location()
                {
                    Title = "Arena da Baixada",
                    City = "Curitiba",
                    Latitude = -25.448333, 
                    Longitude = -49.276944,
                    Url = "http://en.wikipedia.org/wiki/Arena_da_Baixada",
                },
            };
        }
    }
}


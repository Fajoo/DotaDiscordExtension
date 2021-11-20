using System.Text.Json.Serialization;

namespace DotaDiscordExtension.ConsoleTests
{
    public class DAL
    {

        public class Rootobject
        {
            //public Provider provider { get; set; }
            public Map map { get; set; }
            public Player player { get; set; }
            public Hero hero { get; set; }
        }

        //public class Provider
        //{
        //    public string name { get; set; }
        //    public int appid { get; set; }
        //    public int version { get; set; }
        //    public int timestamp { get; set; }
        //}

        public class Map
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            //public string matchid { get; set; }
            //public int game_time { get; set; }
            //public int clock_time { get; set; }
            //!ToDo Enum
            public string game_state { get; set; }
            //!ToDo Enum
            public string win_team { get; set; }
            [JsonPropertyName("customgamename")]
            public string CustomGameName { get; set; }
        }

        public class Player
        {
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public string team_name { get; set; }
        }

      
        public class Hero
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("level")]
            public int Level { get; set; }
        }

        public enum GameState
        {
            
        }

    }
}
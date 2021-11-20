using System.Text.Json.Serialization;

namespace DotaDiscordExtension.Core.Models.DotaData
{
    public class Player
    {
        [JsonPropertyName("activity")]
        public string Activity { get; set; }
        [JsonPropertyName("kills")]
        public int Kills { get; set; }
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }
        [JsonPropertyName("assists")]
        public int Assists { get; set; }
        public string team_name { get; set; }
    }
}
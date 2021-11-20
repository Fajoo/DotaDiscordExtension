using System.Text.Json.Serialization;

namespace DotaDiscordExtension.Core.Models.DotaData
{
    public class Map
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("game_state")]
        public string GameState { get; set; }
        [JsonPropertyName("customgamename")]
        public string CustomGameName { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace DotaDiscordExtension.Core.Models.DotaData
{
    public class Hero
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
    }
}
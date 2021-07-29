namespace DotaDiscordExtension.Core.Models
{
    public class DotaModel
    {
        public (string, string, string) KDA { get; set; }

        public string Team { get; set; }

        public string Hero { get; set; }

        public string Lvl { get; set; }

        public string GameState { get; set; }
    }
}
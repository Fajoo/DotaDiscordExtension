namespace DotaDiscordExtension.Core.Models
{
    public class DotaModel
    {
        public (int, int, int) KDA { get; set; }

        public string Team { get; set; }

        public string Hero { get; set; }

        public int Lvl { get; set; }

        public string GameState { get; set; }
    }
}
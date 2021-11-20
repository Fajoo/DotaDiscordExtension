using DiscordRPC;
using DotaDiscordExtension.Core.Models;
using DotaDiscordExtension.Core.Resources;

namespace DotaDiscordExtension.Core
{
    public static class PresenceConfigure
    {
        private static RichPresence _presence;

        private static Assets _assets;

        static PresenceConfigure()
        {
            _presence = new RichPresence();
            _assets = new Assets();
        }

        public static RichPresence GetPresence(DotaModel model)
        {
            if (model.Hero is null)
            {
                _presence.Details = null;
                _assets.LargeImageKey = "draft";
                _assets.LargeImageText = null;
            }
            else
            {
                var heroName = Dota2Names.GetHeroName(model.Hero);

                _presence.Details = $"K/D/A : {model.KDA.Item1}/{model.KDA.Item2}/{model.KDA.Item3}";
                _assets.LargeImageKey = model.Hero;
                _assets.LargeImageText = model.Lvl == -1 ? $"{heroName}" : $"{heroName} (Lvl: {model.Lvl})";
            }

            _assets.SmallImageKey = model.Team.ToLower();
            _assets.SmallImageText = $"Team {model.Team}";

            _presence.Assets = _assets;
            _presence.State = model.GameState;

            return _presence;
        }
    }
}
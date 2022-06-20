using System.Collections.Generic;

namespace DotaDiscordExtension.Core.Resources
{
    public static class Dota2Names
    {
        public static string GetHeroName(string id) => !HeroNames.TryGetValue(id, out var name) ? "Unknown hero" : name;

        public static Dictionary<string, string> HeroNames { get; set; } 
    }
}
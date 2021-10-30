using System.IO;
using System.Threading.Tasks;
using DotaDiscordExtension.Core.Models;

namespace DotaDiscordExtension.Core
{
    public class SteamConfigure
    {
        private const string templateFile = 
@"""Dota 2 Integration Configuration""
{
    ""uri""           ""http://localhost:4000/""
    ""timeout""       ""5.0""
    ""buffer""        ""0.1""
    ""throttle""      ""0.1""
    ""heartbeat""     ""30.0""
    ""data""
    {
        ""provider""      ""1""
        ""map""           ""1""
        ""player""        ""1""
        ""hero""          ""1""
        ""abilities""     ""1""
        ""items""         ""1""
    }
}";

        private readonly SteamSearcher _steamSearcher;

        public SteamConfigure()
        {
            _steamSearcher = new SteamSearcher();
        }

        public async Task<WriteResult> CreateFileAsync()
        {
            var path = await _steamSearcher.GetPathToDota();

            if (string.IsNullOrEmpty(path)) return WriteResult.Error;

            var directory = $"{path}\\game\\dota\\cfg\\gamestate_integration\\";
            var fullPath = $"{directory}\\gamestate_integration_discordintegration.cfg";

            if (File.Exists(fullPath)) return WriteResult.OK;

            Directory.CreateDirectory(directory);

            File.WriteAllText(fullPath, templateFile);

            return WriteResult.OK;
        }
    }
}
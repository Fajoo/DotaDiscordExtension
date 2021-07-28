using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Gameloop.Vdf;
using Microsoft.Win32;

namespace DotaDiscordExtension.Core
{
    public class SteamSearcher
    {
        public string FindSteamInstallPath()
        {
            const string defaultPath32Bit = @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam";
            const string defaultPath64Bit = @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam";

            return (string)Registry.GetValue(defaultPath32Bit, "InstallPath", null)
                   ?? (string)Registry.GetValue(defaultPath64Bit, "InstallPath", null);
        }

        public async Task<List<string>> GetLibInstall()
        {
            var steamPath = FindSteamInstallPath();

            if (steamPath is null) return null;

            using var reader = new StreamReader($"{steamPath}\\steamapps\\libraryfolders.vdf");

            var deserialize = VdfConvert.Deserialize(await reader.ReadToEndAsync());

            var libs = new List<string>();

            for (var i = 1; i <= deserialize.Value.Count(); i++)
                libs.Add(deserialize.Value[i.ToString()]?["path"]?.ToString());
            
            libs.Insert(0, steamPath);

            return libs
                .Where(i => i != null)
                .ToList(); 
        }

        public async Task<string> GetPathToDota()
        {
            var otherPath = await GetLibInstall();
            if (otherPath is null) return null;

            foreach (var path in otherPath)
            {
                if (File.Exists($"{path}\\steamapps\\appmanifest_570.acf"))
                    return $"{path}\\steamapps\\common\\dota 2 beta";
            }

            return string.Empty;
        }
    }
}
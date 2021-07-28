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
    }
}
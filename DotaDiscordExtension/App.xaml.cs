using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using DotaDiscordExtension.UI.Resources;
using DotaDiscordExtension.UI.Views.Windows;

namespace DotaDiscordExtension.UI
{
    public partial class App : Application
    {
        public static Window ActivedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);

        protected override void OnStartup(StartupEventArgs e)
        {
            //if (string.IsNullOrEmpty(UserSettings.Default.PathToDota)) new PathWindow().Show();
            
            //var procStartInfo = new ProcessStartInfo()
            //{
            //    WindowStyle = ProcessWindowStyle.Normal,
            //    FileName = "cmd.exe",
            //    Arguments = "sc.exe start "
            //};

            //Process.Start(procStartInfo);
        }
    }
}

﻿using System;
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
            if (CheckProcess()) Current.Shutdown();

            if (string.IsNullOrEmpty(UserSettings.Default.PathToDota)) new PathWindow().Show();
            else
            {
                // ToDo 
                var mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }

        private bool CheckProcess()
        {
            var currentProcess = Process.GetCurrentProcess();
            var runningProcess = Process.GetProcesses().FirstOrDefault(process =>
                process.Id != currentProcess.Id &&
                process.ProcessName.Equals(currentProcess.ProcessName, StringComparison.Ordinal));

            return runningProcess is not null;
        }
    }
}

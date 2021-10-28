using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DotaDiscordExtension.Core;
using DotaDiscordExtension.Core.Models;
using DotaDiscordExtension.UI.Infrastructure.Commands;
using DotaDiscordExtension.UI.Resources;
using DotaDiscordExtension.UI.ViewModels.Base;
using MessageBox = HandyControl.Controls.MessageBox;

namespace DotaDiscordExtension.UI.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly DiscordProvider _provider;

        private readonly CancellationTokenSource _token;

        private readonly TimeSpan _delay = new(0, 0, 5);

        private bool _isStarted = false;

        public MainViewModel()
        {
            _provider = new DiscordProvider();

            _token = new CancellationTokenSource();
        }

        private ICommand _closeCommand;
        public ICommand CloseCommand => _closeCommand ?? new LambdaCommand(e =>
        {
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Hide();
            ((CancelEventArgs) e).Cancel = true;
        });

        private ICommand _initCommand;
        public ICommand InitCommand => _initCommand ?? new LambdaCommandAsync(async e =>
        {
            var steamConfigure = new SteamConfigure();
            var result = await steamConfigure.CreateFileAsync(UserSettings.Default.PathToDota);

            if (result == WriteResult.Error)
            {
                // ToDo
                MessageBox.Show("Steam configuration error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            StartProccess();
        });

        private async Task<bool> CheckProcess() =>
            await Task.Run(() =>
                Process.GetProcesses().FirstOrDefault(process =>
                    process.ProcessName.Equals("dota2", StringComparison.Ordinal)) is not null);

        private async Task StartProccess()
        {
            while (!_token.Token.IsCancellationRequested)
            {
             
                switch (await CheckProcess())
                {
                    case true when !_isStarted:
                        _provider.Start();
                        _isStarted = true;
                        break;
                    case false when _isStarted:
                        _provider.Stop();
                        _isStarted = false;
                        break;
                }
                await Task.Delay(_delay);
            }
        }
    }
}
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DotaDiscordExtension.Core;
using DotaDiscordExtension.UI.Infrastructure.Commands;
using DotaDiscordExtension.UI.ViewModels.Base;
using System.Windows.Forms;
using DotaDiscordExtension.UI.Resources;
using MessageBox = HandyControl.Controls.MessageBox;

namespace DotaDiscordExtension.UI.ViewModels
{
    public class PathViewModel : ViewModel
    {
        private readonly SteamSearcher _searcher;

        #region string : Path - Path to dota 

        /// <summary>Path to dota </summary>
        private string _path;

        /// <summary>Path to dota </summary>
        public string Path { get => _path; set => Set(ref _path, value); }

        #endregion

        public PathViewModel()
        {
            _searcher = new SteamSearcher();
        }

        private ICommand _initCommand;
        public ICommand InitCommand => _initCommand ?? new LambdaCommandAsync(async e =>
        {
            var path = await _searcher.GetPathToDota();

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("The system could not determine the folder with the game.\nPlease specify manually.",
                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Path = path;
        });

        private ICommand _openFolderCommand;
        public ICommand OpenFolderCommand => _openFolderCommand ?? new LambdaCommand( e =>
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK) return;

            var newPath = dialog.SelectedPath;
            UserSettings.Default.PathToDota = newPath;
            Path = newPath;
        });

        private ICommand _closeWindowCommand;
        public ICommand CloseWindowCommand => _closeWindowCommand ?? new LambdaCommand(e =>
        {
            var mainWindow = new MainWindow();
            UserSettings.Default.Save();
            App.ActivedWindow.Close();
            mainWindow.Show();
        });
    }
}
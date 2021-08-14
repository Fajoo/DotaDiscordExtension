using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using DotaDiscordExtension.UI.Infrastructure.Commands;
using DotaDiscordExtension.UI.Resources;
using DotaDiscordExtension.UI.ViewModels.Base;

namespace DotaDiscordExtension.UI.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private ICommand _closeCommand;
        public ICommand CloseCommand => _closeCommand ?? new LambdaCommand(e =>
        {
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Hide();
            ((CancelEventArgs) e).Cancel = true;
        });
    }
}
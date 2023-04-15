using NintendoFriends.WPF.MVVM.ViewModels;
using System.Windows;

namespace NintendoFriends.WPF
{

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new NintendoFriendsViewModel()
            };


            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

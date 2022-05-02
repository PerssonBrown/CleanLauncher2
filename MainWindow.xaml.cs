using System.IO;
using System.Windows;
using Panuon.UI.Silver;
using System.Windows.Controls;

namespace CleanLauncher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenHomePage(object sender, RoutedEventArgs e) // 切换界面到 Home
        {
            Pages.Home Home = new Pages.Home();
            UserWindow.Content = new Frame() { Content = Home };
        }

        private void OpenUserPage(object sender, RoutedEventArgs e) // 切换界面到 User
        {
            Pages.User User = new Pages.User();
            UserWindow.Content = new Frame() { Content = User };
        }

        private void OpenSettingsPage(object sender, RoutedEventArgs e) // 切换界面到 Settings
        {
            Pages.Settings Settings = new Pages.Settings();
            UserWindow.Content = new Frame() { Content = Settings };
        }

        private void OpenDownloadPage(object sender, RoutedEventArgs e) // 切换界面到 Download
        {
            Pages.Download Download = new Pages.Download();
            UserWindow.Content = new Frame() { Content = Download };
        }

        private void OpenInfoPage(object sender, RoutedEventArgs e) // 切换界面到 Info
        {
            Pages.Info Info = new Pages.Info();
            UserWindow.Content = new Frame() { Content = Info };
        }
    }
}

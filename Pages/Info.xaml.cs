using System.Windows;
using System.Windows.Controls;

namespace CleanLauncher.Pages
{
    /// <summary>
    /// Info.xaml 的交互逻辑
    /// </summary>
    public partial class Info : Page
    {
        public Info()
        {
            InitializeComponent();
        }

        private void OpenRepository(object sender, RoutedEventArgs e)   // 打开项目仓库
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "https://github.com/PerssonBrown/CleanLauncher2";
            proc.Start();
        }

        private void OpenLauncherWebsite(object sender, RoutedEventArgs e)   // 打开项目仓库
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "https://cleanlauncher.github.io";
            proc.Start();
        }
    }
}

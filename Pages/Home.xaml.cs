using System.Windows.Controls;
using SquareMinecraftLauncher.Minecraft;

namespace CleanLauncher.Pages
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            InitGameVersion();
        }

        private void InitGameVersion()
        {
            Tools tools = new Tools();
            var versions = tools.GetAllTheExistingVersion();
            foreach (var version in versions)
            {
                launchGameVersion.Items.Add(version.version);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SquareMinecraftLauncher.Minecraft;

namespace CleanLauncher.Pages
{
    /// <summary>
    /// Settings.xaml 的交互逻辑
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            InitJavaversions();
        }

        private void InitJavaversions()
        {
            Tools tools = new Tools();
            var javaPaths = tools.GetJavaPath();
            foreach (var javaPath in javaPaths)
            {
                javaVersions.Items.Add(javaPath.Path);
            }
        }

        private void ChangeRAMSettingMode(object sender, RoutedEventArgs e)
        {
            if (autoSetRAM.IsChecked == true)
            {
                userSetRAM.IsEnabled = false;
            }
            else if (autoSetRAM.IsChecked == false)
            {
                userSetRAM.IsEnabled = true;
            }
        }
    }
}

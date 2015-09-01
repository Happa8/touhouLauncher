using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TouhouLaunchar
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.ProcessStartInfo th06StartInfo = new System.Diagnostics.ProcessStartInfo();
            //th06StartInfo.FileName = "D:\\東方\\東方紅魔郷\\東方紅魔郷.exe";

            System.Diagnostics.Process th06Start = System.Diagnostics.Process.Start("D:\\東方\\東方紅魔郷\\東方紅魔郷.exe");


        }
    }
}

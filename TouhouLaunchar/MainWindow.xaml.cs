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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th07Start = System.Diagnostics.Process.Start("D:\\東方\\東方妖々夢\\th07.exe");
        }

        private void th08_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th08Start = System.Diagnostics.Process.Start("D:\\東方\\東方永夜抄\\th08.exe");
        }

        private void th09_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th09Start = System.Diagnostics.Process.Start("D:\\東方\\東方花映塚\\th09.exe");
        }

        private void th10_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th10Start = System.Diagnostics.Process.Start("D:\\東方\\東方風神録\\th10.exe");
        }

        private void th11_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th11Start = System.Diagnostics.Process.Start("D:\\東方\\東方地霊殿\\th11.exe");
        }

        private void th12_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th12Start = System.Diagnostics.Process.Start("D:\\東方\\東方星蓮船\\th12.exe");
        }

        private void th13_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th13Start = System.Diagnostics.Process.Start("D:\\東方\\東方神霊廟\\th13.exe");
        }

        private void th14_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th14Start = System.Diagnostics.Process.Start("D:\\東方\\東方輝針城\\th14.exe");
        }

        private void th15_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th15Start = System.Diagnostics.Process.Start("D:\\東方\\東方紺珠伝\\th15.exe");
        }

        private void th095_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th095Start = System.Diagnostics.Process.Start("D:\\東方\\東方文花帖\\th095.exe");
        }

        private void th125_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th125Start = System.Diagnostics.Process.Start("D:\\東方\\ダブルスポイラー\\th125.exe");
        }

        private void th128_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th128Start = System.Diagnostics.Process.Start("D:\\東方\\妖精大戦争\\th128.exe");
        }

        private void th143_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th143Start = System.Diagnostics.Process.Start("D:\\東方\\弾幕アマノジャク\\th143.exe");
        }

        private void th105_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th105Start = System.Diagnostics.Process.Start("D:\\東方\\th105\\th105.exe");
        }

        private void th123_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th123Start = System.Diagnostics.Process.Start("D:\\東方\\th123\\th123.exe");
        }

        private void th135_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th135Start = System.Diagnostics.Process.Start("D:\\東方\\th135\\th135.exe");
        }

        private void th145_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process th145Start = System.Diagnostics.Process.Start("D:\\東方\\th145\\th145.exe");
        }

        private void openSetting_Click(object sender, RoutedEventArgs e)
        {
            Setting SetObj = new Setting();
            SetObj.ShowDialog();
        }
    }
}

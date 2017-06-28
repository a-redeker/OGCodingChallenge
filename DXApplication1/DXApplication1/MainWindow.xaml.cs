using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new DiagnoseWindow();
            this.Visibility = Visibility.Hidden;
            x.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var x = new RegisterWindow();
            this.Visibility = Visibility.Hidden;
            x.ShowDialog();
            this.Visibility = Visibility.Visible;
        }
    }
}

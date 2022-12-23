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

namespace lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            b1.Style = (Style)b1.FindResource("stile1");

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            b2.Style = (Style)b2.FindResource("stile1");

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            b3.Style = (Style)b3.FindResource("stile1");

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
        }
    }
}

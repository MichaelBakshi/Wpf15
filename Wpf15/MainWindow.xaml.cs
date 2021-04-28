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

namespace Wpf15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Auto.Visibility = Visibility.Hidden;
            ReadOnly.Visibility = Visibility.Visible;
            Customize.Visibility = Visibility.Hidden;
        }

        private void Read_Only_Click(object sender, RoutedEventArgs e)
        {
            Auto.Visibility = Visibility.Hidden;
            ReadOnly.Visibility = Visibility.Visible;
            Customize.Visibility = Visibility.Hidden;
        }

        private void Auto__Click(object sender, RoutedEventArgs e)
        {
            Auto.Visibility = Visibility.Visible;
            ReadOnly.Visibility = Visibility.Hidden;
            Customize.Visibility = Visibility.Hidden;
        }

        private void Customize__Click(object sender, RoutedEventArgs e)
        {
            Auto.Visibility = Visibility.Hidden;
            ReadOnly.Visibility = Visibility.Hidden;
            Customize.Visibility = Visibility.Visible;
        }
    }
}
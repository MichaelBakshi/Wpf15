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
        List<Order> orders = new List<Order>();

        public MainWindow()
        {
            InitializeComponent();

            orders.Add(new Order() { Id = 1, Name = "John", Surname = "Doe", Age = 20, Email = "JohnDoe@Mail.com", MembershipOwner = false, SumOfOrder = 153, OrderStatus = MyEnum.New });

            dgorders.ItemsSource = orders;

        }
        public enum MyEnum { None=0, New=1, Processing=2, Shipped=3, Received=4 }

        private void ReadOnly_Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ReadOnly_Button");
        }
        private void Auto_Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Auto_Button");
        }
        private void Customize_Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Customize_Button");
        }
    }
}

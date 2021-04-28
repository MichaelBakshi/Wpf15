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
    /// Interaction logic for AutoUserControl.xaml
    /// </summary>
    public partial class AutoUserControl : UserControl
    {
        List<Order> orders = new List<Order>();
        public AutoUserControl()
        {
            orders.Add(new Order() { Id = 1, Name = "John", Surname = "Doe", Age = 20, Email = "JohnDoe@Mail.com", MembershipOwner = false, SumOfOrder = 153, OrderStatus = MyEnum.New });
            orders.Add(new Order() { Id = 2, Name = "Jack", Surname = "Doe", Age = 27, Email = "John@Mail.com", MembershipOwner = true, SumOfOrder = 354, OrderStatus = MyEnum.Processing });
            orders.Add(new Order() { Id = 3, Name = "Julie", Surname = "Doe", Age = 21, Email = "Johoe@Mail.com", MembershipOwner = false, SumOfOrder = 14, OrderStatus = MyEnum.New });
            orders.Add(new Order() { Id = 4, Name = "Jil", Surname = "Doe", Age = 24, Email = "Johnoe@Mail.com", MembershipOwner = true, SumOfOrder = 120, OrderStatus = MyEnum.Received });
            orders.Add(new Order() { Id = 5, Name = "Johan", Surname = "Doe", Age = 22, Email = "JnDoe@Mail.com", MembershipOwner = false, SumOfOrder = 234, OrderStatus = MyEnum.New });

            InitializeComponent();
            dgOrders.IsReadOnly = false;

            this.Visibility = Visibility.Hidden;
            dgOrders.ItemsSource = orders;
        }
    }
}

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
            orders.Add(new Order() { Id = 2, Name = "Jack", Surname = "Jill", Age = 27, Email = "Jill@Mail.com", MembershipOwner = true, SumOfOrder = 354, OrderStatus = MyEnum.Processing });
            orders.Add(new Order() { Id = 3, Name = "Julie", Surname = "Roberts", Age = 51, Email = "Juilie@Mail.com", MembershipOwner = false, SumOfOrder = 142, OrderStatus = MyEnum.Shipped });


            InitializeComponent();
            dgOrders.IsReadOnly = false;
            this.Visibility = Visibility.Hidden;
            dgOrders.ItemsSource = orders;
        }
    }
}

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
    /// Interaction logic for CustomizeUserControl.xaml
    /// </summary>
    public partial class CustomizeUserControl : UserControl
    {
        List<Order> orders = new List<Order>();
        public CustomizeUserControl()
        {

            orders.Add(new Order() { Id = 1, Name = "John", Surname = "Doe", Birthday = new DateTime(2005, 12, 03), Email = "JohnDoe@Mail.com", MembershipOwner = false, SumOfOrder = 153, OrderStatus = MyEnum.New });
            orders.Add(new Order() { Id = 2, Name = "Jack", Surname = "Doe", Birthday = new DateTime(1984, 08, 09), Email = "John@Mail.com", MembershipOwner = true, SumOfOrder = 354, OrderStatus = MyEnum.Processing });
            orders.Add(new Order() { Id = 3, Name = "Julie", Surname = "Doe", Birthday = new DateTime(1979, 07, 13), Email = "Johoe@Mail.com", MembershipOwner = false, SumOfOrder = 14, OrderStatus = MyEnum.New });
            orders.Add(new Order() { Id = 4, Name = "Jil", Surname = "Doe", Birthday = new DateTime(1999, 11, 03), Email = "Johnoe@Mail.com", MembershipOwner = true, SumOfOrder = 120, OrderStatus = MyEnum.Received });
            orders.Add(new Order() { Id = 5, Name = "Johan", Surname = "Doe", Birthday = new DateTime(1980, 05, 23), Email = "JnDoe@Mail.com", MembershipOwner = false, SumOfOrder = 234, OrderStatus = MyEnum.New });

            InitializeComponent();
            dgOrders.ItemsSource = orders;
            this.Visibility = Visibility.Hidden;
            dgOrders.IsReadOnly = false;

        }
    }
}

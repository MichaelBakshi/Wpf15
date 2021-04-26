using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wpf15.MainWindow;

namespace Wpf15
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool MembershipOwner { get; set; }
        public DateTime Birthday { get; set; }
        public double SumOfOrder { get; set; }
        public MyEnum OrderStatus { get; set; }
    }
}

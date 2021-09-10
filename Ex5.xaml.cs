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
using System.Windows.Shapes;

namespace WpfApp3_Bindings
{
    /// <summary>
    /// Interaction logic for Ex5.xaml
    /// </summary>
    public partial class Ex5 : Window
    {
        public Ex5()
        {
            InitializeComponent();
            List<Customer> lst = new List<Customer>()
            {
                new Customer{CustomerId=101,CustomerName="Raj",CustomerAddress="New delhi"},
                 new Customer{CustomerId=103,CustomerName="Rajee",CustomerAddress="Agra"},
                  new Customer{CustomerId=102,CustomerName="Raj kumar",CustomerAddress="Noida"}
            };
            cmb.ItemsSource = lst;
            cmb.SelectedValuePath = "CustomerId";
            cmb.DisplayMemberPath = "CustomerName";
          //  this.DataContext = lst;

        }
    }
}

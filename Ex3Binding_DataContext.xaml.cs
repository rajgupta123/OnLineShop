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
    /// Interaction logic for Ex3Binding_DataContext.xaml
    /// </summary>
    public partial class Ex3Binding_DataContext : Window
    {
        public Ex3Binding_DataContext()
        {
            InitializeComponent();
            Employee employee = new Employee();
            employee.EmpId = 101;
            employee.EmpName = "Raj kumar";
            employee.Address = "New delhi";
            this.DataContext = employee;
        }
    }
}

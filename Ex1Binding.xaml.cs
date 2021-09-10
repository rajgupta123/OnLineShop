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
    /// Interaction logic for Ex1Binding.xaml
    /// </summary>
    public partial class Ex1Binding : Window
    {
        public Ex1Binding()
        {
            InitializeComponent();
            slider1.Value = 50;
            TXT1.Text = slider1.Value.ToString();
        }
    }
}

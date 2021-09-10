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
    /// Interaction logic for Ex4.xaml
    /// </summary>
    public partial class Ex4 : Window
    {
        public Ex4()
        {
            InitializeComponent();
        }
        // 1,2,3,4    1234

        private void combox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //  string[] str=combox1.SelectedItem.ToString().Split(new[] { ":" },StringSplitOptions.None);
            //MessageBox.Show(str[0]);
            //MessageBox.Show(str[1]);
            ComboBoxItem cm = (ComboBoxItem)combox1.SelectedItem;
            MessageBox.Show(cm.Content.ToString());
        }
    }
}

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
using NWD_WPF.Models;

namespace NWD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e) {
            MessageBox.Show(comboBox.SelectedItem.ToString());
            int result = NWD.NWDIter(Convert.ToInt32(textBoxA.Text),Convert.ToInt32(textBoxB.Text));
            textBox1.Text = result.ToString();
        }
    }
}

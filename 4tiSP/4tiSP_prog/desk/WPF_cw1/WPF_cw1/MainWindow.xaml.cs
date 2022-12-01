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
using WPF_cw1.Models;

namespace WPF_cw1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private UsersRepo _repo = new UsersRepo();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            labelHello.Content = "Hello from WPF";
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            foreach (User user in _repo.GetFakeUsers()) {
                ListBox.Items.Add(user);
            }
        }
    }
}

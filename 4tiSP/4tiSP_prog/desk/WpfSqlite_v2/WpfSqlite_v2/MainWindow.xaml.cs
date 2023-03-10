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
using WpfSqlite_v2.Models;

namespace WpfSqlite_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Game> games;
        private AppDbContext _db = new AppDbContext();
        public MainWindow() {
            
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            games = _db.Games.ToList();
            
            dataGrid.ItemsSource = games;
            dataGrid.Columns[0].Visibility = Visibility.Hidden;
        }
    }
}

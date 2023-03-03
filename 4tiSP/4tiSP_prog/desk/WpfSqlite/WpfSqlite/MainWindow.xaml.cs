using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Microsoft.EntityFrameworkCore;

namespace WpfSqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private readonly ProductContext _dbContext = new ProductContext();
        private CollectionViewSource categoryViewSource;
        public MainWindow()
        {
            InitializeComponent();
            categoryViewSource = (CollectionViewSource) FindResource(nameof(categoryViewSource));
        }

        private void ButtonSave(object sender, RoutedEventArgs e) {
            _dbContext.SaveChanges();
            categoryDataGrid.Items.Refresh();
            productsDataGrid.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //_dbContext.Database.EnsureCreated();
            _dbContext.Categories.Load();
            categoryViewSource.Source = 
                _dbContext.Categories.Local.ToObservableCollection();
        }

        protected override void OnClosing(CancelEventArgs e) {
            _dbContext.Dispose();
            base.OnClosing(e);
        }
    }
}

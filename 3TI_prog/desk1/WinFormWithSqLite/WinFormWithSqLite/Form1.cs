using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.Models;

namespace WinFormWithSqLite
{
    public partial class Form1 : Form
    {
        
        private MyAppDbContext _db = new MyAppDbContext();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _db.Database.EnsureCreated();
            List<Product> products = _db.Products.Include(p => p.Category).ToList();
            dataGridView1.DataSource = products;
            dataGridView1.Columns["Category"].DataPropertyName = "Category";
            //_db = new MyAppDbContext(connString);
            //_db.Database.EnsureCreated();
            //_db.Categories.Load();
            //this.categoryBindingSource.DataSource = _db.Categories.Local.ToBindingList();
        }



        private void dataGridView2_SelectionChanged(object sender, EventArgs e) {
            //var category = (Category)this.dataGridView2.CurrentRow.DataBoundItem;
            //if (category != null) {
            //    this._db.Entry(category).Collection(e=>e.Products).Load();
            //}
        }
    }
}
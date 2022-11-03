using System.Configuration;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.Models;

namespace WinFormWithSqLite
{
    public partial class Form1 : Form
    {
        private AppDBContext _db;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new AppDBContext();
            _db.Database.EnsureCreated();
            List<Product> products = _db.Products.ToList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            this._db?.Dispose();
            this._db = null;
        }
    }
}
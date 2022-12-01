using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.Models;

namespace WinFormWithSqLite
{
    public partial class AddCategryForm : Form {
        private MyAppDbContext _db;
        public AddCategryForm(MyAppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void tbCategoryName_TextChanged(object sender, EventArgs e) {
            btnAdd.Enabled = tbCategoryName.Text.Trim().Length > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = tbCategoryName.Text.Trim();
            _db.Categories.Add(new Category { Name = categoryName });
            _db.SaveChanges();
            Close();
        }
    }
}

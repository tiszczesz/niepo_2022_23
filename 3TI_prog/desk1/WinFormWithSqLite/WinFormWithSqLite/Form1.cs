using Microsoft.EntityFrameworkCore;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.Models;
using WinFormWithSqLite.ViewModels;

namespace WinFormWithSqLite;

public partial class Form1 : Form {
    private readonly MyAppDbContext _db = new();
    private Product _selectedProdukt;
    private int _selectedRow = -1;

    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
        //_db.Database.EnsureCreated();
        FillListProducts();
        FillCategory();
    }

    private void FillListProducts() {
        var products = _db.Products.Include(p => p.Category);
        dataGridView1.DataSource =
            products
                .Select(e => new ViewModelProductCtagory {
                    ProductId = e.ProductId,
                    ProductName = e.Name,
                    CategoryName = e.Category.Name
                }).ToList();
        dataGridView1.Columns["ProductId"].Visible = false;
    }

    private void FillCategory() {
        var categories = _db.Categories.ToList();
        cBoxCategories.DataSource = categories;
        cBoxCategories.DisplayMember = "Name";
        cBoxCategories.ValueMember = "CategoryId";
        cBoxCategoriesEdit.DataSource = categories;
        cBoxCategoriesEdit.DisplayMember = "Name";
        cBoxCategoriesEdit.ValueMember = "CategoryId";
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(tbName.Text)) {
            MessageBox.Show("Brak danych");
            return;
        }

        var name = tbName.Text.Trim();
        var id = Convert.ToInt32(cBoxCategories.SelectedValue);
        var product = new Product { Name = name, CategoryId = id };
        _db.Products.Add(product);
        _db.SaveChanges();
        FillListProducts();
    }

    private void btnAddCategory_Click(object sender, EventArgs e) {
        new AddCategryForm(_db).ShowDialog();
        FillCategory();
    }

    private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) {
        _selectedRow = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
        if (_selectedRow == 1) {
            _selectedProdukt = GetProduct();
            if (_selectedProdukt != null) {
                var result = MessageBox.Show($" Czy usun¹æ produkt: {_selectedProdukt.Name} {_selectedProdukt.Category.Name}",
                    "ZatwierdŸ", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    _db.Products.Remove(_selectedProdukt);
                    _db.SaveChanges();
                    FillListProducts();
                }
            }
        }
    }

    private Product? GetProduct() {
        var elem = dataGridView1.SelectedRows[0];
        var idProduct = Convert.ToInt32(elem.Cells["ProductId"].Value);
        var pp = _db.Products.FirstOrDefault(p => p.ProductId == idProduct);
        return pp;
    }

    private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
        panel2.Visible = true;
        _selectedRow = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
        if (_selectedRow == 1) {
            _selectedProdukt = GetProduct();
            if (_selectedProdukt != null) {
                cBoxCategoriesEdit.SelectedItem = _selectedProdukt.Category;
                tbNameEdit.Text = _selectedProdukt.Name;
            }
        }
    }

    private void btnUpdateProduct_Click(object sender, EventArgs e) {
        if (_selectedRow == 1  && !string.IsNullOrEmpty(tbNameEdit.Text)) {
            //_selectedProdukt.Name = tbNameEdit.Text;
            //_selectedProdukt.CategoryId = Convert.ToInt32(cBoxCategoriesEdit.SelectedIndex);
            //_db.Products.Update(_selectedProdukt);
            //_db.SaveChanges();
            //FillListProducts();
            //todo
        }
    }
}
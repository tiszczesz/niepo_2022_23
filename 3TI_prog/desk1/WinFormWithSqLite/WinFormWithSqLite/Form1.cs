using Microsoft.EntityFrameworkCore;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.Models;
using WinFormWithSqLite.ViewModels;

namespace WinFormWithSqLite; 

public partial class Form1 : Form {
    private readonly MyAppDbContext _db = new();

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
                    ProductName = e.Name,
                    CategoryName = e.Category.Name
                }).ToList();
    }

    private void FillCategory() {
        var categories = _db.Categories.ToList();
        cBoxCategories.DataSource = categories;
        cBoxCategories.DisplayMember = "Name";
        cBoxCategories.ValueMember = "CategoryId";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(tbName.Text)) {
            MessageBox.Show("Brak danych");
            return;
        }

        var name = tbName.Text.Trim();
        int id = Convert.ToInt32(cBoxCategories.SelectedValue);
        Product product = new Product { Name = name, CategoryId = id };
        _db.Products.Add(product);
        _db.SaveChanges();
        FillListProducts();

    }

    private void btnAddCategory_Click(object sender, EventArgs e) {
        new AddCategryForm(_db).ShowDialog();
        FillCategory();
    }
}
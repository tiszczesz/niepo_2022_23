using Microsoft.EntityFrameworkCore;
using WinFormWithSqLite.Data;
using WinFormWithSqLite.ViewModels;

namespace WinFormWithSqLite; 

public partial class Form1 : Form {
    private readonly MyAppDbContext _db = new();

    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
        _db.Database.EnsureCreated();
        var products = _db.Products.Include(p => p.Category);
        dataGridView1.DataSource =
            products
                .Select(e => new ViewModelProductCtagory {
                    ProductName = e.Name,
                    CategoryName = e.Category.Name
                }).ToList();
    }


   
}
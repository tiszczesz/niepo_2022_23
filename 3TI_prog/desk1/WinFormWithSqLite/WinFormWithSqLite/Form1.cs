using System.Configuration;
using WinFormWithSqLite.Data;

namespace WinFormWithSqLite
{
    public partial class Form1 : Form
    {
        private AppDBContext _db;
        public Form1()
        {
            _db = new AppDBContext();
            InitializeComponent();
        }
    }
}
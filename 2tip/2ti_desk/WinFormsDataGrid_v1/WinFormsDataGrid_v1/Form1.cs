
using WinFormsDataGrid_v1.Models;

namespace WinFormsDataGrid_v1
{
    public partial class Form1 : Form
    {
        public RepoWorkers Repo { get; set; }
        public Form1()
        {
            InitializeComponent();
            Repo = new RepoWorkers();
        }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvWorkers.DataSource = Repo.Workers;
        }

        private void dgvWorkers_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Enabled = true;
        }
    }
}
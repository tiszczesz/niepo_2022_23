namespace WF_Sqlite_cw1
{
    public partial class Form1 : Form
    {
        private RepoNotes _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new RepoNotes();
            var notes = _db.GetNotes();
            dataGridView1.DataSource = notes;
        }
    }
}
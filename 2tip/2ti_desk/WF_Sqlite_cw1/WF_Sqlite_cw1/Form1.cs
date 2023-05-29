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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                tbContent.Text = File.ReadAllText(fileName); //fileName;
            }
            else
            {
                MessageBox.Show("Wybrano anuluj");
            }
        }

        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            lChars.Text = "Iloœæ znaków: " + tbContent.Text.Length.ToString();
            lLines.Text = "Iloœæ linii:" + tbContent.Lines.Length.ToString();
            btnAdd.Enabled = tbContent.Text.Length > 0 && tbContent.Text.Length < 1000;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName,tbContent.Text);
            }
        }
    }
}
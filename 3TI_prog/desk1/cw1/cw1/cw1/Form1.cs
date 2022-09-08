namespace cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NIE OK");
            }
        }
    }
}
namespace cw1
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    this.fileName = openFileDialog1.FileName;
                    this.Text += " - " + fileName;
                    toolStripStatusLabel2.Text = $"Wybrano plik: {fileName}";
                    sr.Close();
                }catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                
              
            }
            else
            {
                // MessageBox.Show("NIE OK");
                toolStripStatusLabel2.Text = "Nie wybrano pliku";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = "Nie wybrano pliku";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fileName;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(saveFileDialog1.FileName == ""){
                        MessageBox.Show("Brak nazwy pliku");
                        return;
                    }
                }catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
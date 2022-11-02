

using System.Text;

namespace WinFormCw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStart.Text = "Hello from WindowsForms";
            // ................
            label1.Text = "Antoni Ma³ecki";
            label2.Text = "Klasa 2TI";
            label3.Text = DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLocalTime().ToString();
            lblTime.Text = time;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (
                String.IsNullOrEmpty(tbFirstName.Text.Trim()) ||
                String.IsNullOrEmpty(tbLastName.Text.Trim()) || 
                String.IsNullOrEmpty(tbAge.Text.Trim())  
            ) {
                MessageBox.Show("Brak imienia, nazwiska lub wieku");
                return;
            } 

            StringBuilder sb = new StringBuilder();
            sb.Append(tbFirstName.Text + " " + tbLastName.Text);
            sb.Append("\nWiek: " + tbAge.Text);
            lblResult.Text = sb.ToString();
        }
    }
}
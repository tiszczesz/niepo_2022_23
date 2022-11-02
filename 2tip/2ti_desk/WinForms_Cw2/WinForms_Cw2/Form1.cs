using System.Text;

namespace WinForms_Cw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            List<int> lista = new List<int>();
            for (int i = 0; i < 50; i++) {
                lista.Add(i);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var elem in lista) {
                sb.Append(elem).Append(Environment.NewLine);
            }

            textBox1.Text = sb.ToString();
        }
    }
}
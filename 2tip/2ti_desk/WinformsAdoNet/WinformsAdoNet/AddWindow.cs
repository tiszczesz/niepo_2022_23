using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAdoNet
{
    public partial class AddWindow : Form {
        private Form1 form1;
        public AddWindow(Form1 form1 = null)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tu bedzie zapisywanie do bazy
            string? title = "Fake kurs";
            string? place = "Fake miejsce";
            decimal? price = 34.90m;
            form1.SaveToDb(title, place, price);
        }
    }
}

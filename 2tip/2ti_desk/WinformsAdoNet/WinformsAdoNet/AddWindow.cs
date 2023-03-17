using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsAdoNet.Models;

namespace WinformsAdoNet
{
    public partial class AddWindow : Form
    {
        private Form1 form1;
        private bool isEdit;
        private Course toUpdate;
        public AddWindow(Form1 form1 = null, bool isEdit = false)
        {
            InitializeComponent();
            this.form1 = form1;
            this.isEdit = isEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tu bedzie zapisywanie do bazy
            try
            {
                string? title = txtCourseName.Text.Trim();
                string? place = txtCoursePlace.Text.Trim();
                decimal? price = Convert.ToDecimal(txtCoursePrice.Text.Trim());
                if (isEdit == false) {
                    form1.InserToDb(title, place, price);
                }
                else {
                    form1.UpdateToDb(title,place,price,toUpdate.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWindow_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var grid = form1.GetDataGridView();
                toUpdate = grid.SelectedRows[0].DataBoundItem as Course;
                txtCourseName.Text = toUpdate.Title;
                txtCoursePlace.Text = toUpdate.Place;
                txtCoursePrice.Text = toUpdate.Price.ToString();
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDataGrid_v1.Models;

namespace WinFormsDataGrid_v1
{
    public partial class EditForm : Form {
        private Worker? _worker;
        public EditForm(Worker? worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //wypełnianie pól formularza przy użyciu _worker
            tbFirstName.Text = _worker?.FirstName;
            tbLastName.Text = _worker?.LastName;
            tbSlary.Text = _worker?.Salary.ToString();
            tbJob.Text = _worker?.Job;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_worker == null) {
                //zapisywanie do datagridview
            }
            else {
                // todo
            }
        }
    }
}

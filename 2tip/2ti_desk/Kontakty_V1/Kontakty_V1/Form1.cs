using Kontakty_V1.Models;

namespace Kontakty_V1
{
    public partial class Form1 : Form
    {
        private MyContacts _contacts = new MyContacts();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadContacts_Click(object sender, EventArgs e) {
            listBoxContacts.DataSource = _contacts.ToViewString();
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            var addNew = new AddNewForm();
            addNew.ShowDialog();
        }
    }
}
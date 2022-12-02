using Kontakty_V1.Models;
using System.Configuration;

namespace Kontakty_V1
{
    public partial class Form1 : Form {
        private MyContacts _contacts;
        public string? fileName;
        public Form1()
        {
            InitializeComponent();
            fileName = ConfigurationManager.AppSettings.Get("fileName");
            _contacts  = new MyContacts(fileName);
        }

        private void btnLoadContacts_Click(object sender, EventArgs e) {
            listBoxContacts.DataSource = _contacts.ToViewString();
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            
            var addNew = new AddNewForm(_contacts);
            addNew.ShowDialog();
            listBoxContacts.DataSource = _contacts.ToViewString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var myFileName = fileName ?? "contacts.txt";
            _contacts.SaveToFile(myFileName);
        }
    }
}
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
            UpdateListBoxContacts();
            btnDelete.Enabled = true;
        }

        private void UpdateListBoxContacts() {
            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = _contacts.Contacts;
            listBoxContacts.DisplayMember = "ToListBoxLine";
            
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            
            var addNew = new AddNewForm(_contacts);
            addNew.ShowDialog();
            UpdateListBoxContacts();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var myFileName = fileName ?? "contacts.txt";
            _contacts.SaveToFile(myFileName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listBoxContacts.SelectedItems.Count == 0) return;
            //1. wybrac element zazanaczony i zrzutowac na Contact Contact sel = (vvv as Contact)
            //sprawdzic czy nie null
            //2 . Usun¹æ z listy kontaktów myContact.Contacts.Remove(sel)
            //3. Updatowaæ listboxa a dok³adniej Datasource
            var c = listBoxContacts.SelectedItem as Contact ;
            if(c == null) return;
            _contacts.Contacts.Remove(c);
            UpdateListBoxContacts();
        }
    }
}
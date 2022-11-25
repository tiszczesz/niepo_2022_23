using Kontakty_V1.Models;

namespace Kontakty_V1; 

public partial class AddNewForm : Form {
    private readonly MyContacts _contacts;

    public AddNewForm(MyContacts contacts) {
        _contacts = contacts;

        InitializeComponent();
    }

    private void AddNewForm_Load(object sender, EventArgs e) {
        var lastId = _contacts.Contacts.Max(c => c.Id) + 1;
        tbId.Text = lastId.ToString();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        Close();
    }

    private void btnAddContact_Click(object sender, EventArgs e) {
        if (string.IsNullOrWhiteSpace(tbFirstname.Text) ||
            string.IsNullOrWhiteSpace(tbLastname.Text) ||
            string.IsNullOrWhiteSpace(tbEmail.Text)) {
            MessageBox.Show("Dane błędne!!!");
            return;
        }

        var contact = new Contact {
            Id = Convert.ToInt32(tbId.Text),
            Firstname = tbFirstname.Text,
            Lastname = tbLastname.Text,
            Email = tbEmail.Text
        };
        _contacts.Contacts.Add(contact);
        Close();
    }
}
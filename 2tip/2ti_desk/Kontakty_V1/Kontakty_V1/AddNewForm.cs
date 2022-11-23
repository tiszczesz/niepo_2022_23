using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontakty_V1.Models;

namespace Kontakty_V1
{
    public partial class AddNewForm : Form
    {
        private MyContacts _contacts;
        public AddNewForm(MyContacts contacts) {
            _contacts = contacts;
            
            InitializeComponent();

        }

        private void AddNewForm_Load(object sender, EventArgs e) {
            int lastId = _contacts.Contacts.Max(c => c.Id) + 1;
            tbId.Text = lastId.ToString();
        }
    }
}

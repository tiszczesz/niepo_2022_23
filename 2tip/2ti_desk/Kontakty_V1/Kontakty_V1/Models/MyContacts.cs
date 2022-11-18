using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakty_V1.Models
{
    public class MyContacts
    {
        public List<Contact> Contacts { get; set; } 
        public MyContacts() {
            Contacts = new List<Contact> {
                new Contact { Id = 1, Firstname = "Jan", Lastname = "Nowak", Email = "nn@onort.pl" },
                new Contact { Id = 2, Firstname = "Adam", Lastname = "Głowa", Email = "sdfds@onort.pl" },
                new Contact { Id = 3, Firstname = "Tomasz", Lastname = "Nowak", Email = "erere@onet.pl" },
                new Contact { Id = 4, Firstname = "Grażyna", Lastname = "Romańska", Email = "fff22@gmail.coml" },
                new Contact { Id = 5, Firstname = "Monoka", Lastname = "Hajduk", Email = "rr344@interia.pl" },
            };
        }

        public List<string> ToViewString() {
            List<string> list = new List<string>();
            foreach (var contact in Contacts) {
                list.Add(contact.Firstname+"\t "+contact.Lastname+"\t email: "+contact.Email);
            }

            return list;
        }
    }
}

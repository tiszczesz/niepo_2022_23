using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kontakty_V1.Models
{
    public class MyContacts
    {
        public List<Contact> Contacts { get; set; } 
        public MyContacts(string fileName) {
            if (File.Exists(fileName)) {
                Contacts = LoadFromFile(fileName);
            }
            else {
                Contacts = new List<Contact> {
                    new Contact { Id = 1, Firstname = "Jan", Lastname = "Nowak", Email = "nn@onort.pl" },
                    new Contact { Id = 2, Firstname = "Adam", Lastname = "Głowa", Email = "sdfds@onort.pl" },
                    new Contact { Id = 3, Firstname = "Tomasz", Lastname = "Nowak", Email = "erere@onet.pl" },
                    new Contact { Id = 4, Firstname = "Grażyna", Lastname = "Romańska", Email = "fff22@gmail.coml" },
                    new Contact { Id = 5, Firstname = "Monika", Lastname = "Hajduk", Email = "rr344@interia.pl" },
                };
            }
        }

        private List<Contact> LoadFromFile(string fileName) {
            List<Contact> list = new List<Contact>();
            var data = File.ReadAllLines(fileName);
            foreach (var line in data) {
                Contact? c = JsonSerializer.Deserialize<Contact>(line);
                if (c != null) {
                    list.Add(c);
                }
                
            }
            return list;
        }

        public List<string> ToViewString() {
            List<string> list = new List<string>();
            foreach (var contact in Contacts) {
                list.Add(contact.Firstname+"\t "+contact.Lastname+"\t email: "+contact.Email);
            }

            return list;
        }

        public void SaveToFile(string fileName) {
            List<string> toJsonArray = new List<string>();
            foreach (var contact in Contacts) {
                toJsonArray.Add(JsonSerializer.Serialize(contact));
            }
            File.WriteAllLines(fileName,toJsonArray);
        }
    }
}

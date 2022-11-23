namespace cw8_WebRazor.Models
{
    public class RepoContacts
    {
        public List<Contact> Contacts { get; set; }
        private readonly string _filePath = "contacts.txt";
        public RepoContacts() {
            if (File.Exists(_filePath)) {
               // Contacts = LoadFromFile(_filePath);
            }
            else {
                Contacts = GetContacts();
                SaveToFile(_filePath);
            }
            
        }
        public static List<Contact> GetContacts() {
            return new List<Contact> {
                new Contact { Id = 1, Name = "Adam", Phone = "2131313", Email = "dd@onet.pl" },
                new Contact { Id = 2, Name = "Dominika", Phone = "324243432", Email = "dd@onet.pl" },
                new Contact { Id = 3, Name = "Rafał", Phone = "2424242", Email = "dd@onet.pl" },
                new Contact { Id = 4, Name = "Marzena", Phone = "242424", Email = "dd@onet.pl" },
                new Contact { Id = 5, Name = "Roman", Phone = "24242424", Email = "ddd@onet.pl" }
            };
        }

        public void SaveToFile(string filePath) {
            List<string> toLines = new List<string>();
            foreach (var contact in Contacts) {
                toLines.Add(contact.SerializeContact());
            }
            File.WriteAllLines(_filePath,toLines);
        }
    }
}

using MySql.Data.MySqlClient;

namespace WebApp_Mysql_cw1.Models
{
    public class UsersRepo {
        private string _connString;
        public UsersRepo(string connString) {
            _connString = connString;
        }

        public List<User> GetAll() {
            List<User> list = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(_connString)) {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM users";
                MySqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows) {
                    while (rd.Read()) {
                        list.Add(new User {
                            Id = rd.GetInt32(0),
                            Firstname = rd.GetString(1),
                            Lastname = rd.GetString(2),
                            CreateDate = rd.GetDateTime(3)
                        });
                    }
                }
            }
            return list;
        }

        public void AddUser(User user)
        {
            List<User> list = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(_connString))
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                
            }
            
        }
    }
}

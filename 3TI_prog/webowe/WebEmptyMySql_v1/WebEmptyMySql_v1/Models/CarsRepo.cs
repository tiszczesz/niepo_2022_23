using MySql.Data.MySqlClient;

namespace WebEmptyMySql_v1.Models
{
    public class CarsRepo {
        private string connString;

        public CarsRepo(string conn) {
            this.connString = conn;
        }

        public List<Car> GetCars() {
            List<Car> cars = new List<Car>();
            using (MySqlConnection conn = new MySqlConnection(connString)) {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM cars";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cars.Add(new Car {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Distance = reader.GetInt32(2),
                            Price = reader.GetDecimal(3)
                        });
                    }
                }
            }
            return cars;
        }
    }
}

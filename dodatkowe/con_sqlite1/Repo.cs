using Microsoft.Data.Sqlite;

public class Repo
{
    private string dbName = "myDb.db";

    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();
        using (var connection = new SqliteConnection("" +
                                                     new SqliteConnectionStringBuilder {
                                                         DataSource = this.dbName
                                                     })) {
            connection.Open();

            using (var transaction = connection.BeginTransaction())
            {
                var selectCommand = connection.CreateCommand();
                selectCommand.Transaction = transaction;
                selectCommand.CommandText = "SELECT * FROM COMPANY";
                
                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var message = reader.GetString(0);
                        Console.WriteLine(message);
                    }
                }

                transaction.Commit();
            }
        }
            

        return customers;
    }
}
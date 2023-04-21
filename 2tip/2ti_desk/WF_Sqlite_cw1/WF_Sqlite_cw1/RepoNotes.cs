using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WF_Sqlite_cw1
{
    public class RepoNotes {
        private string _connString = "Data Source=notes.db";
        public List<Note> GetNotes() {
            List<Note> notes = new List<Note>();
            using (var connect = new SqliteConnection(_connString)) {
                connect.Open();
                var command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM Note";
                SqliteDataReader rd = command.ExecuteReader();
                if (rd.HasRows) {
                    while (rd.Read()) {
                        notes.Add(new Note {
                            Id = rd.GetInt32(0),
                            Content = rd.GetString(1),
                            Author = rd.GetString(2),
                            Date = rd.GetDateTime(3).Date
                        });
                    }
                }
                connect.Close();
            }

            return notes;
        }
    }
}

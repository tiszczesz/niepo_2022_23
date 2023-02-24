using System.Configuration;
using System.Data.SqlClient;

namespace WinformsAdoNet
{
    public partial class Form1 : Form {
        private string connString;
        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppCourses;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
        }
    }
}
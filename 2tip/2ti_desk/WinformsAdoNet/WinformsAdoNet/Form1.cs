using System.Configuration;
using System.Data.SqlClient;
using WinformsAdoNet.Models;

namespace WinformsAdoNet
{
    public partial class Form1 : Form
    {
        private string connString;
        public List<Course> Courses { get; set; }
        public Form1()
        {
            InitializeComponent();
            Courses = new List<Course>();
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppCourses;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.DataSource = Courses;
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT * FROM Course";
                SqlCommand command = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string? title = reader["Title"].ToString();
                        string? place = reader["Place"].ToString();
                        decimal? price = Convert.ToDecimal(reader["Price"]);
                        Courses.Add(new Course
                        {
                            Id = id,
                            Title = title,
                            Place = place,
                            Price = price
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
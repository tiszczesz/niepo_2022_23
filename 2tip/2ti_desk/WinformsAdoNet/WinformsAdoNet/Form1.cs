using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
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
            
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppCourses;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                Courses = new List<Course>();
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
                RefrashGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddWindow(this).ShowDialog();
        }

        public void InserToDb(string title, string place, decimal? price)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = $"INSERT INTO Course(Title,Place,Price) VALUES('{title}', '{place}', '{Convert.ToString(price, CultureInfo.InvariantCulture)}')";
                // MessageBox.Show(sql);
                SqlCommand command = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    Courses.Add(new Course { Title = title, Place = place, Price = price });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            LoadData();
        }
        public void UpdateToDb(string title, string place, decimal? price,int id )
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = $"UPDATE  Course SET Title='{title}',Place='{place}',"
                             +$"Price='{Convert.ToString(price, CultureInfo.InvariantCulture)}' WHERE Id={id}";
                // MessageBox.Show(sql);
                SqlCommand command = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            LoadData();
        }

        private void RefrashGrid()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Courses;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedCourse = dataGridView1.SelectedRows[0].DataBoundItem as Course;
            if (selectedCourse != null)
            {
                DeleteFromCourse(selectedCourse);
            }
        }

        private void DeleteFromCourse(Course selectedCourse)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = $"DELETE FROM Course WHERE Id={selectedCourse.Id}";
                //MessageBox.Show(sql);
                SqlCommand command = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    Courses.Remove(selectedCourse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            RefrashGrid();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            AddWindow win = new AddWindow(this,true);
            win.ShowDialog();
        }

        public DataGridView GetDataGridView() {
            return dataGridView1;
        }
    }
}
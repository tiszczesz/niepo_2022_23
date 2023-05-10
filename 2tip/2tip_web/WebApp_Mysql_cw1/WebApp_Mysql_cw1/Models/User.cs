namespace WebApp_Mysql_cw1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Sqlite_cw1
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}

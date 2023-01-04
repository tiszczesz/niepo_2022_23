using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDataGrid_v1.Models
{
    public class Worker
    {
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Job { get; set; }
    }
}

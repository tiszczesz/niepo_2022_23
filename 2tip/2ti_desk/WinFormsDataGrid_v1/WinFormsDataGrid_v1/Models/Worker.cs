using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDataGrid_v1.Models
{
    public class Worker
    {
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Pensja")]
        public decimal Salary { get; set; }

        [DisplayName("Stanowisko")]
        public string Job { get; set; }
    }
}

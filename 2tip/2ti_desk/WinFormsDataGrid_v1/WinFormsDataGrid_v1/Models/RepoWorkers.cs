using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDataGrid_v1.Models
{
    public class RepoWorkers
    {
        public List<Worker> Workers { get; set; }

        public RepoWorkers() {
            GetWorkers();
        }

        public void GetWorkers() {
            Workers = new List<Worker> {
                new Worker {
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Salary = 3900,
                    Job = "kierownik"
                },
                new Worker {
                    FirstName = "Roman",
                    LastName = "Nowak",
                    Salary = 6900,
                    Job = "starszy kierownik"
                },
                new Worker {
                    FirstName = "Renata",
                    LastName = "Małecka",
                    Salary = 5500,
                    Job = "asystentka"
                },
                new Worker {
                    FirstName = "Tomasz",
                    LastName = "Bomasz",
                    Salary = 4600,
                    Job = "kierowca"
                },
                new Worker {
                    FirstName = "Grażyna",
                    LastName = "Tomasik",
                    Salary = 5500,
                    Job = "sprzedawca"
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormWithSqLite.Models;

namespace WinFormWithSqLite.ViewModels
{
    public class ViewModelProductCtagory
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}

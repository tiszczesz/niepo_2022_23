using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormWithSqLite.Data
{
    public class AppDBContext : DbContext
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;
    }
}

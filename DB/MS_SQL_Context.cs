using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDB.DB
{
    internal class MS_SQL_Context : DbContext
    {
        string connectionString = 
        "Server=192.168.49.180; Database=LksndrDB_test; User Id = stud; Password=stud; TrustServerCertificate=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        [Key] //теперь это ключ
        public int Id { get; set; } 
        
        public string Name { get; set; }

        public string Group { get; set; }
    }
}

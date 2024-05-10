using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet7WithSqlExample.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GLAVOD9;Initial Catalog=UniversityDB;Integrated Security=True;Trust Server Certificate=True");

        }
        

        public DbSet<Student> Students { get; set; }
    }
}

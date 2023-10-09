using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> persons { get; set; }
        public DbSet<Address> address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantı dizesini burada tanımlayın.
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;");

        }
    }

}

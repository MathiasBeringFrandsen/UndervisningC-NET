using Lektion8.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class PerformerContext : DbContext
    {
        public PerformerContext()
        {

        }

        public DbSet<Performer> Performers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G31MV79\\SQLEXPRESS;Initial Catalog=Performers; Integrated Security=SSPI; TrustServerCertificate=true");
        }
    }
}

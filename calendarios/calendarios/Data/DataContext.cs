using calendarios.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarios.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=DBCalendarios; Integrated Security=SSPI; TrustServerCertificate=True");
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

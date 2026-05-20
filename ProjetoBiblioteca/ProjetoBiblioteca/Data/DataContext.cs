using Microsoft.EntityFrameworkCore;
using ProjetoBiblioteca.Model;

namespace ProjetoBiblioteca.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLSERVER2014ECE; Initial Catalog=BDBiblioteca; Integrated Security=SSPI; TrustServerCertificate=True");
        }

        public DbSet<Livro> Livros { get; set; }
    }
}

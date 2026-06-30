using Microsoft.EntityFrameworkCore;
using ProjetoBiblioteca.Model;

namespace ProjetoBiblioteca.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RNPKNFE\SQLEXPRESS; Initial Catalog=BDBiblioteca; Integrated Security=SSPI; TrustServerCertificate=True");
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
    }
}

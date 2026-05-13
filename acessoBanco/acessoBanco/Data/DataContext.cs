using Microsoft.EntityFrameworkCore;
using acessoBanco.Model;

namespace acessoBanco.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LABGPC17\SQLSERVER2014ECE; Initial Catalog=BDBiblioteca; Integrated Security=SSPI");
        }

        public DbSet<Livro> Livros { get; set; }
    }
}

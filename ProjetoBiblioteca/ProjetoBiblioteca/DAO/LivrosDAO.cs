using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBiblioteca.Data;
using ProjetoBiblioteca.Model;

namespace ProjetoBiblioteca.DAO
{
    internal static class LivrosDAO
    {
        public static void Salvar(Livro item)
        {
            DataContext dc = new DataContext();

            dc.Livros.Add(item);
            dc.SaveChanges();
        }
    }
}

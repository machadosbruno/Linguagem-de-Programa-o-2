using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Data
{
    internal static class LivroDAO
    {
        internal static void Excluir(Livro livro)
        {
            using DataContext dc = new();
            dc.Livros.Remove(livro);
            dc.SaveChanges();
        }

        internal static Livro Obter(int id)
        {
            using DataContext dc = new();
            return dc.Livros.Find(id);
        }

        internal static List<Livro> Pesquisar()
        {
            using DataContext dc = new();
            List<Livro> resultado = dc.Livros.OrderByDescending(p => p.DataPublicacao).ThenBy(p => p.Titulo).ToList();
            return resultado;
        }

        internal static bool Existe(int id)
        {
            using DataContext dc = new();
            return dc.Livros.Any(p=>p.Id == id);
            
        }

        internal static void Salvar(Livro livro)
        {
            using DataContext dc = new DataContext();
            dc.Livros.Add(livro);
            dc.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        internal static void Atualizar(Livro item)
        {
            using DataContext dc = new DataContext();
            dc.Livros.Update(item);
            dc.SaveChanges();
        }

        internal static void Excluir(Livro livro)
        {
            using DataContext dc = new();
            dc.Livros.Remove(livro);
            dc.SaveChanges();
        }

        internal static bool Existe(int id)
        {
            using DataContext dc = new();
            return dc.Livros.Any(p => p.Id == id);
        }

        internal static bool LivroPorAutor(Livro livroSelecionado)
        {
            using DataContext dc = new();
            return dc.Livros.Any(p => p.AutorId == livroSelecionado.AutorId);
        }

        internal static Livro Obter(int id)
        {
            using DataContext dc = new();
            return dc.Livros.Find(id);
        }

        internal static List<Livro> Pesquisar(Livro livro)
        {
            using DataContext dc = new();
            List<Livro> livros = new List<Livro>();
            if (!livro.NomeAutor.IsNullOrEmpty())
            {
                livros = dc.Livros.Include(p => p.Editora).Where(p => p.NomeAutor.Contains(livro.NomeAutor)).OrderBy(p => p.Titulo).ThenByDescending(p => p.DataPublicacao).ToList();
            }
            else if (!livro.AutorA.Email.IsNullOrEmpty())
            {
                livros = dc.Livros.Include(p => p.Editora).Where(p => p.EmailAutor.Contains(livro.EmailAutor)).OrderBy(p => p.Titulo).ThenByDescending(p => p.DataPublicacao).ToList();
            }
            //if (!livro.Titulo.IsNullOrEmpty())
            //{
                livros = dc.Livros.Include(p => p.Editora).Where(p => p.Titulo.Contains(livro.Titulo)).OrderBy(p => p.Titulo).ThenByDescending(p => p.DataPublicacao).ToList();
            //}
            return livros;
        }

        internal static void Salvar(Livro livro)
        {
            using DataContext dc = new DataContext();
            dc.Livros.Add(livro);
            dc.SaveChanges();
        }
    }
}

using Microsoft.IdentityModel.Tokens;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Data
{
    internal class AutorDAO
    {
        internal static void Atualizar(Autor item)
        {
            using DataContext dc = new DataContext();
            dc.Autores.Update(item);
            dc.SaveChanges();
        }

        internal static void Excluir(Autor item)
        {
            using DataContext dc = new();
            dc.Autores.Remove(item);
            dc.SaveChanges();
        }

        internal static bool Existe(int id)
        {
            using DataContext dc = new();
            return dc.Autores.Any(p => p.Id == id);
        }

        internal static Autor Obter(int id)
        {
            using DataContext dc = new();
            return dc.Autores.Find(id);
        }

        internal static List<Autor> Pesquisar(Autor item)
        {
            using DataContext dc = new();
            List<Autor> autores = new List<Autor>();
            if (!item.Email.IsNullOrEmpty())
            {
                autores = dc.Autores.Where(p => p.Email.Equals(item.Email)).OrderBy(p => p.Nome).ToList();
            }
            else
            {
                autores = dc.Autores.Where(p => p.Nome.Contains(item.Nome)).OrderBy(p => p.Nome).ToList();
            }
            return autores;
        }

        internal static void Salvar(Autor item)
        {
            using DataContext dc = new DataContext();
            dc.Autores.Add(item);
            dc.SaveChanges();
        }
    }
}

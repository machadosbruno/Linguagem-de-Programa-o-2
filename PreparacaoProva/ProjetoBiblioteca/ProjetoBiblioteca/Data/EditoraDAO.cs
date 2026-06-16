using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Data
{
    internal class EditoraDAO
    {
        internal static void Atualizar(Editora item)
        {
            using DataContext dc = new DataContext();
            dc.Editoras.Update(item);
            dc.SaveChanges();
        }

        internal static void Excluir(Editora item)
        {
            using DataContext dc = new();
            dc.Editoras.Remove(item);
            dc.SaveChanges();
        }

        internal static bool Existe(int id)
        {
            using DataContext dc = new();
            return dc.Editoras.Any(p => p.Id == id);
        }

        internal static Editora Obter(int id)
        {
            using DataContext dc = new();
            return dc.Editoras.Find(id);
        }

        internal static List<Editora> Pesquisar(Editora item)
        {
            using DataContext dc = new();
            return dc.Editoras.Where(p => p.Nome.Contains(item.Nome)).OrderBy(p => p.Nome).ToList();
        }

        internal static void Salvar(Editora item)
        {
            using DataContext dc = new DataContext();
            dc.Editoras.Add(item);
            dc.SaveChanges();
        }
    }
}

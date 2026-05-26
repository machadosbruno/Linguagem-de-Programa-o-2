using ProjetoBiblioteca.Data;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Controller
{
    internal static class LivroController
    {
        internal static void Salvar(Livro item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);

            if (item.Titulo.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Titulo_Obrigatorio);

            if(item.Titulo.Trim().Length > 100)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Titulo_Comprimento);

            if (item.DataPublicacao.Date > DateTime.Today)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.DataPublicacao_Maximo);

            item.Titulo = item.Titulo.Trim();
            item.DataPublicacao = item.DataPublicacao.Date;

            LivroDAO.Salvar(item);
        }
    
        internal static List<Livro> Pesquisar()
        {
            //using DataContext dc = new();

            //return dc.Livros.Where(p => p.Titulo.Contains(livro.Titulo.Trim()).;

            return LivroDAO.Pesquisar();
        }

        internal static Livro Obter(int id)
        {
            return LivroDAO.Obter(id);
        }
        public static bool removeu = false;
        internal static void Excluir(Livro livro)
        {
            if(Existe(livro.Id))
            {
                LivroDAO.Excluir(livro);

            }
        }

        private static bool Existe(int id)
        {
            return LivroDAO.Existe(id);
        }
    }
}

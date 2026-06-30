using Microsoft.IdentityModel.Tokens;
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

            if(item.EditoraId <= 0)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Editora_Invalida);

            if(!EditoraController.Existe(item.EditoraId))
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Editora_Invalida);

            item.Titulo = item.Titulo.Trim();
            item.DataPublicacao = item.DataPublicacao.Date;

            LivroDAO.Salvar(item);
        }
    
        internal static List<Livro> Pesquisar(Livro livro)
        {
            if(livro == null)
            {
                livro = new Livro();
            }
            else
            {
                if (!livro.Titulo.IsNullOrEmpty())
                    livro.Titulo = livro.Titulo.Trim();
                if (!livro.NomeAutor.IsNullOrEmpty())
                    livro.NomeAutor = livro.NomeAutor.Trim();
                if (!livro.EmailAutor.IsNullOrEmpty())
                    livro.EmailAutor = livro.EmailAutor.Trim();
            }
            
            return LivroDAO.Pesquisar(livro);
        }

        internal static Livro Obter(int id)
        {
           return LivroDAO.Obter(id);
        }

        internal static bool Existe(int id)
        {
            return LivroDAO.Existe(id);
        }

        internal static void Excluir(Livro livro)
        {
            if (Existe(livro.Id))
                LivroDAO.Excluir(livro);
            else
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);
        }

        internal static void Atualizar(Livro item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);

            if (item.Titulo.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Titulo_Obrigatorio);

            if (item.Titulo.Trim().Length > 100)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Titulo_Comprimento);

            if (item.DataPublicacao.Date > DateTime.Today)
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.DataPublicacao_Maximo);

            item.Titulo = item.Titulo.Trim();
            item.DataPublicacao = item.DataPublicacao.Date;

            if(!Existe(item.Id))
                throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);

            LivroDAO.Atualizar(item);
        }

        internal static bool LivroPorAutor(Livro livroSelecionado)
        {
            if(livroSelecionado != null)
            {
                return LivroDAO.LivroPorAutor(livroSelecionado);
            }
            else
            {
                return false;
            }
        }
    }
}

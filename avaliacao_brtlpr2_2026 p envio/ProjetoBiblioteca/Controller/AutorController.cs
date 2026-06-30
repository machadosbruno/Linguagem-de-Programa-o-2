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
    internal static class AutorController
    {
        internal static void Salvar(Autor item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Item_Invalido);

            if (item.Nome.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Nome_Obrigatorio);

            if (item.Email.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Email_Obrigatorio);

            if (item.DataNascimento.Date.ToString() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.DataNascimento_Obrigatorio);

            if (item.DataNascimento.Date > DateTime.Today)
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.DataNascimento_Maximo);

            item.Nome = item.Nome.Trim();
            item.DataNascimento = item.DataNascimento.Date;

            AutorDAO.Salvar(item);
        }

        internal static List<Autor> Pesquisar(Autor autor)
        {
            if (autor == null)
            {
                autor = new Autor();
            }
            else
            {
                if(!autor.Nome.IsNullOrEmpty())
                    autor.Nome = autor.Nome.Trim();
                if (!autor.Email.IsNullOrEmpty())
                    autor.Email = autor.Email.Trim();
            }

            return AutorDAO.Pesquisar(autor);
        }

        internal static Autor Obter(int id)
        {
            return AutorDAO.Obter(id);
        }

        internal static bool Existe(int id)
        {
            return AutorDAO.Existe(id);
        }

        internal static void Excluir(Autor autor)
        {
            if (Existe(autor.Id))
                AutorDAO.Excluir(autor);
            else
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Item_Invalido);
        }

        internal static void Atualizar(Autor item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Item_Invalido);

            if (item.Nome.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Nome_Obrigatorio);

            if (item.Email.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Email_Obrigatorio);

            if (item.DataNascimento.Date.ToString() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.DataNascimento_Obrigatorio);

            if (item.DataNascimento.Date > DateTime.Today)
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.DataNascimento_Maximo);

            item.Nome = item.Nome.Trim();
            item.DataNascimento = item.DataNascimento.Date;

            if (!Existe(item.Id))
                throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Item_Invalido);

            AutorDAO.Atualizar(item);
        }
    }
}

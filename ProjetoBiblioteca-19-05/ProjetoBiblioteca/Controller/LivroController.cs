using ProjetoBiblioteca.DAO;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
using ProjetoBiblioteca.Utils.MensagensErro;
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
                throw new ExcecaoEsperada(MensagensErro.ItemInvalido);

            if (item.Titulo.Trim() == "") 
                throw new ExcecaoEsperada(MensagensErro.TituloObrigatorio);

            if (item.Titulo.Trim().Length > 100)
                throw new ExcecaoEsperada(MensagensErro.TituloTamanhoMaximo);

            if (item.DataPublicacao > DateTime.Today)
                throw new ExcecaoEsperada(MensagensErro.DataPublicacaoMaxima);

            LivrosDAO.Salvar(item);
        }
    }
}

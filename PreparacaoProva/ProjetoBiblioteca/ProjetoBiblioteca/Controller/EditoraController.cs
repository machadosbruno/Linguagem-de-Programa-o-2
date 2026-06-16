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
    internal class EditoraController
    {
        internal static void Salvar(Editora item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Item_Invalido);

            if (item.Nome.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Nome_Obrigatorio);

            if (item.Nome.Trim().Length > 50)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Nome_Comprimento);

            if (item.Cidade.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Cidade_Obrigatoria);

            if (item.AnoFundacao < 1800 || item.AnoFundacao > DateTime.Today.Year)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Ano_Invalido);

            string cnpj = item.CNPJ.Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "").Trim();
            if (cnpj == "" || cnpj.Length != 14)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.CNPJ_Invalido);


            item.Nome = item.Nome.Trim();
            item.Cidade = item.Cidade.Trim();

            EditoraDAO.Salvar(item);
        }

        internal static List<Editora> Pesquisar(Editora item)
        {
            if (item == null)
            {
                item = new Editora();
            }
            else
            {
                item.Nome = item.Nome.Trim();
            }

            return EditoraDAO.Pesquisar(item);
        }

        internal static Editora Obter(int id)
        {
            return EditoraDAO.Obter(id);
        }

        internal static bool Existe(int id)
        {
            return EditoraDAO.Existe(id);
        }

        internal static void Excluir(Editora item)
        {
            if (Existe(item.Id))
                EditoraDAO.Excluir(item);
            else
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Item_Invalido);
        }

        internal static void Atualizar(Editora item)
        {
            if (item == null)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Item_Invalido);

            if (item.Nome.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Nome_Obrigatorio);

            if (item.Nome.Trim().Length > 50)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Nome_Comprimento);

            if (item.Cidade.Trim() == "")
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Cidade_Obrigatoria);

            if (item.AnoFundacao < 1800 || item.AnoFundacao > DateTime.Today.Year)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Ano_Invalido);

            item.Nome = item.Nome.Trim();
            item.Cidade = item.Cidade.Trim();

            if (!Existe(item.Id))
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.Item_Invalido);

            string cnpj = item.CNPJ.Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "").Trim();
            if (cnpj == "" || cnpj.Length != 14)
                throw new ExcecaoEsperada(Utils.MensagensErro.Editora.CNPJ_Invalido);

            EditoraDAO.Atualizar(item);
        }
    }
}

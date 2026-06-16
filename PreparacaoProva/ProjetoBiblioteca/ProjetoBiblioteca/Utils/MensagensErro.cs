using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Utils
{
    namespace MensagensErro
    {
        internal static class Livro
        {
            internal static string Item_Invalido = "O livro informado é inválido";
            internal static string Titulo_Obrigatorio = "O título do livro é obrigatório";
            internal static string Titulo_Comprimento = "O comprimento máximo do título é de 100 caracteres";
            internal static string DataPublicacao_Maximo = "A data de publicação não pode ser uma data futura";
            internal static string Editora_Invalida = "Escolha uma editora";
        }

        internal static class Editora
        {
            internal static string Item_Invalido = "A editora informada é inválida";
            internal static string Nome_Obrigatorio = "O nome da editora é obrigatório";
            internal static string Nome_Comprimento = "O nome da editora deve conter, no máximo, 50 caracteres";
            internal static string Cidade_Obrigatoria = "A cidade da editora é obrigatória";
            internal static string Ano_Invalido = "O ano de fundação da editora deve ser maior que 1799 e menor ou igual ao ano atual";
            internal static string CNPJ_Invalido = "Informe um CNPJ válido";
        }

        internal static class Geral
        {
            internal static string Erro_Geral = "Houve um erro com o sistema. Contate o administrador";
        }
    }
}

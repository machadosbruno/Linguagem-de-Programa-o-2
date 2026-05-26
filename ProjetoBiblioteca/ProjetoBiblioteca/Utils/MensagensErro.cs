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
        }

        internal static class Geral
        {
            internal static string Erro_Geral = "Houve um erro com o sistema. Contate o administrador";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Utils
{

    namespace MensagensErro
    {
        internal static class MensagensErro
        {
            internal static string ItemInvalido = "Livro inválido";
            internal static string TituloObrigatorio = "O título do Livro é obrigatório!";
            internal static string TituloTamanhoMaximo = "O tamanho máximo do título é de 100 caracteres!";
            internal static string TituloInvalido = "Informe um título válido!";
            internal static string DataPublicacaoMaxima = "A data de publicação não pode ser maior que a data de hoje!";
        }  
        internal static class Geral()
        {
            internal static string ErroGeral = "Houve um erro inesperado no sistema :/ Por favor contato o administrador";
        }
    }
}

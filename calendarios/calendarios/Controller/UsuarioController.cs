using calendarios.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarios.Controller
{
    public class UsuarioController : DefaultController
    {
        internal static Usuario getUsuario()
        {
            return Context.Usuarios.FirstOrDefault();
        }

        internal static bool SalvarUsuario(Usuario usuario)
        {
            if(usuario.Nome != null || usuario.Nome != "" || usuario.Foto != null || usuario.Foto.Length == 0)
            {
                try
                {
                    Context.Add(usuario);
                    Context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar usuário.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível salvar o usuário pois os\n" +
                                "dados foram informados incorretamente.");
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio8
{
    public partial class FormPrincipal : formPadrao
    {
        List<Usuario> usuarios = new List<Usuario>();

        public FormPrincipal()
        {
            InitializeComponent();
            this.ForeColor = System.Drawing.Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastro novo = new FormCadastro();
            novo.ShowDialog();

            if(novo.usuarioInserido != null)
            {
                usuarios.Add(novo.usuarioInserido);
                MessageBox.Show("Usuário inserido com sucesso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormExibicao(usuarios).ShowDialog();
        }
    }
}

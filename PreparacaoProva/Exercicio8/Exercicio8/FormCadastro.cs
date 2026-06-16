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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public Usuario usuarioInserido = null;

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtUsername.Text.Trim() == "")
                errorProvider1.SetError(txtUsername, "O nome de usuário deve ser informado");

            if (txtSenha.Text.Trim() == "")
                errorProvider1.SetError(txtSenha, "A senha deve ser informada");

            if (rdoSituacaoAtivo.Checked == false && rdoSituacaoInativo.Checked == false)
                errorProvider1.SetError(rdoSituacaoInativo, "A situação do usuário deve ser informada");

            if (!errorProvider1.HasErrors)
            {
                usuarioInserido = new Usuario
                {
                    Username = txtUsername.Text.Trim(),
                    Senha = txtSenha.Text,
                    Situacao = rdoSituacaoAtivo.Checked ? "A" : "I"
                };
                Close();
            }
            else
                usuarioInserido = null;
        }

        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarioInserido == null)
            {
                DialogResult result = MessageBox.Show("Deseja realmente fechar o formulário", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}

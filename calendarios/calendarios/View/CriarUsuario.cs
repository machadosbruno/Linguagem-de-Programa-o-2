using calendarios.Model;
using calendarios.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calendarios.View
{
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {

            InitializeComponent();
        }

        private string caminhoFotoPerfil = "";
        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Filtra para o usuário conseguir ver e selecionar apenas arquivos de imagem [cite: 704]
            openFileDialog1.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"; // [cite: 705]

            // Abre a janela e verifica se o usuário escolheu um arquivo e clicou em OK [cite: 708]
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Guarda o endereço do arquivo selecionado na variável global [cite: 706]
                caminhoFotoPerfil = openFileDialog1.FileName;

                // Exibe a imagem escolhida visualmente dentro do PictureBox [cite: 699]
                picBoxUsuario.Image = Image.FromFile(caminhoFotoPerfil);
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear(); // Limpa erros anteriores
            if(txtNome.Text == "")
            {
                errorProvider.SetError(txtNome, "Campo obrigatório");
            }
            if(picBoxUsuario.Image == null)
            {
                errorProvider.SetError(btnSelecionarFoto, "Selecione uma foto de perfil");
            }
            else
            {
                Usuario usuario = new Usuario {
                    Nome = txtNome.Text,
                    Foto = File.ReadAllBytes(caminhoFotoPerfil)
                };
                bool sucesso = UsuarioController.SalvarUsuario(usuario);
                if (sucesso)
                {
                    MessageBox.Show("Dados salvos com sucesso!");
                    Close();
                }
            }
        }
    }
}

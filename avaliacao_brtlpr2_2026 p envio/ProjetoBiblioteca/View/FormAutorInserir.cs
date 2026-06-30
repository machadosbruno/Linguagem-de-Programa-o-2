using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
using ProjetoBiblioteca.Utils.MensagensErro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca.View
{
    public partial class FormAutorInserir : Form
    {
        //null se inserção, diferente nulo se atualização
        private int? idEditar;

        public FormAutorInserir(int? idAutor = null)
        {
            idEditar = idAutor;
            InitializeComponent();
            if (idEditar != null)
                this.Text = "Editar Autor";
        }

        internal bool salvou = false;

        private void FormAutorInserir_Load(object sender, EventArgs e)
        {
            dtpDataNascimento.MaxDate = DateTime.Now;

            if (idEditar != null)
            {
                try
                {
                    Model.Autor autor = AutorController.Obter(idEditar.Value);
                    if (autor == null)
                        throw new ExcecaoEsperada(Utils.MensagensErro.Autor.Item_Invalido);
                    else
                    {
                        txtNome.Text = autor.Nome;
                        txtEmail.Text = autor.Email;
                        dtpDataNascimento.Value = autor.DataNascimento;
                    }
                }
                catch (ExcecaoEsperada ee)
                {
                    MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                catch (Exception ex)
                {
                    //log ex
                    MessageBox.Show(Utils.MensagensErro.Geral.Erro_Geral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime dataNascimento = dtpDataNascimento.Value;

            if (nome == "")
                errorProvider1.SetError(txtNome, Utils.MensagensErro.Autor.Nome_Obrigatorio);

            if (email == "")
                errorProvider1.SetError(txtEmail, Utils.MensagensErro.Autor.Email_Obrigatorio);

            Model.Autor buscar = new Model.Autor() { Email = email.Trim() };
            if (AutorController.Pesquisar(buscar).Count > 0)
                errorProvider1.SetError(txtEmail, Utils.MensagensErro.Autor.Email_Ja_Cadastrado);

            if (dataNascimento.ToString() == "")
                errorProvider1.SetError(dtpDataNascimento, Utils.MensagensErro.Autor.DataNascimento_Obrigatorio);

            if (dataNascimento.Date > DateTime.Today)
                errorProvider1.SetError(dtpDataNascimento, Utils.MensagensErro.Autor.DataNascimento_Maximo);

            if (!errorProvider1.HasErrors)
            {
                Model.Autor autor = new Model.Autor
                {
                    Nome = nome,
                    Email = email,
                    DataNascimento = dataNascimento,
                };

                try
                {
                    if (idEditar == null)
                        AutorController.Salvar(autor);
                    else
                    {
                        autor.Id = idEditar.Value;
                        AutorController.Atualizar(autor);
                    }
                    MessageBox.Show("Autor salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salvou = true;
                    Close();
                }
                catch (ExcecaoEsperada ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //log ex
                    MessageBox.Show(Utils.MensagensErro.Geral.Erro_Geral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
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
    public partial class FormLivroInserir : Form
    {
        //null se inserção, diferente nulo se atualização
        private int? idEditar;

        public FormLivroInserir(int? idLivro = null)
        {
            idEditar = idLivro;
            InitializeComponent();
            if (idEditar != null)
                this.Text = "Editar Livro";
        }

        internal bool salvou = false;

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string titulo = txtTitulo.Text.Trim();
            DateTime dataPublicacao = dtpDataPublicacao.Value;

            if (titulo == "")
                errorProvider1.SetError(txtTitulo, Utils.MensagensErro.Livro.Titulo_Obrigatorio);

            if (titulo.Length > 100)
                errorProvider1.SetError(txtTitulo, Utils.MensagensErro.Livro.Titulo_Comprimento);

            if (dataPublicacao.Date > DateTime.Today)
                errorProvider1.SetError(dtpDataPublicacao, Utils.MensagensErro.Livro.DataPublicacao_Maximo);

            if (cboEditora.SelectedIndex == 0)
                errorProvider1.SetError(cboEditora, Utils.MensagensErro.Livro.Editora_Invalida);

            if (cboAutor.SelectedIndex == 0)
                errorProvider1.SetError(cboAutor, Utils.MensagensErro.Livro.Autor_Invalido);

            if (!errorProvider1.HasErrors)
            {
                Livro livro = new Livro
                {
                    Titulo = titulo,
                    DataPublicacao = dataPublicacao,
                    EditoraId = ((Editora)cboEditora.SelectedItem).Id,
                    AutorId = ((Autor)cboAutor.SelectedItem).Id
                };

                try
                {
                    if (idEditar == null)
                        LivroController.Salvar(livro);
                    else
                    {
                        livro.Id = idEditar.Value;
                        LivroController.Atualizar(livro);
                    }
                    MessageBox.Show("Livro salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormLivroInserir_Load(object sender, EventArgs e)
        {
            dtpDataPublicacao.MaxDate = DateTime.Now;

            //Editoras
            List<Editora> editoras= EditoraController.Pesquisar(new Editora { Nome = ""});
            editoras.Insert(0, new Editora { Nome = "<Escolha>", Id = -1 });
            cboEditora.DataSource = editoras;

            if (idEditar != null)
            {
                try
                {
                    Livro livro = LivroController.Obter(idEditar.Value);
                    if (livro == null)
                        throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);
                    else
                    {
                        txtTitulo.Text = livro.Titulo;
                        dtpDataPublicacao.Value = livro.DataPublicacao;
                        cboEditora.SelectedValue = livro.EditoraId;
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


            //Autores
            List<Autor> autores = AutorController.Pesquisar(new Autor { Nome = "" });
            autores.Insert(0, new Autor { Nome = "<Escolha>", Id = -1 });
            cboAutor.DataSource = autores;

            if (idEditar != null)
            {
                try
                {
                    Livro livro = LivroController.Obter(idEditar.Value);
                    if (livro == null)
                        throw new ExcecaoEsperada(Utils.MensagensErro.Livro.Item_Invalido);
                    else
                    {
                        txtTitulo.Text = livro.Titulo;
                        dtpDataPublicacao.Value = livro.DataPublicacao;
                        cboAutor.SelectedValue = livro.AutorId;
                        cboEditora.SelectedValue = livro.EditoraId;
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
    }
}

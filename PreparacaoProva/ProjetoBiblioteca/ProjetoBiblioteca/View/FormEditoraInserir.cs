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
    public partial class FormEditoraInserir : Form
    {
        //null se inserção, diferente nulo se atualização
        private int? idEditar;
        internal bool salvou = false;
        public FormEditoraInserir(int? idEditora = null)
        {
            idEditar = idEditora;
            InitializeComponent();
            if (idEditar != null)
                this.Text = "Editar Editora";
        }

        private void FormEditoraInserir_Load(object sender, EventArgs e)
        {
            txtAnoFundacao.Minimum = 1800;
            txtAnoFundacao.Maximum = DateTime.Today.Year;
            txtAnoFundacao.Value = DateTime.Today.Year;

            if(idEditar != null)
            {
                Editora atual = EditoraController.Obter(idEditar.Value);
                txtNome.Text = atual.Nome;
                txtCNPJ.Text = atual.CNPJ;
                txtCidade.Text = atual.Cidade;
                txtAnoFundacao.Value = atual.AnoFundacao;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string nome = txtNome.Text.Trim();
            string cnpj = txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "").Trim();
            string cidade = txtCidade.Text.Trim();
            
            if (nome == "")
                errorProvider1.SetError(txtNome, Utils.MensagensErro.Editora.Nome_Obrigatorio);

            if(nome.Length > 50)
                errorProvider1.SetError(txtNome, Utils.MensagensErro.Editora.Nome_Comprimento);

            if (cnpj == "" || cnpj.Length != 14)
                errorProvider1.SetError(txtCNPJ, Utils.MensagensErro.Editora.CNPJ_Invalido);

            if (cidade == "")
                errorProvider1.SetError(txtCidade, Utils.MensagensErro.Editora.Cidade_Obrigatoria);

            int anoFundacao = 0;
            try
            {
                anoFundacao = int.Parse(txtAnoFundacao.Text);

                if(anoFundacao < 1800 || anoFundacao > DateTime.Today.Year)
                    errorProvider1.SetError(txtAnoFundacao, Utils.MensagensErro.Editora.Ano_Invalido);
            }
            catch
            {
                errorProvider1.SetError(txtAnoFundacao, Utils.MensagensErro.Editora.Ano_Invalido);
            }

            if(!errorProvider1.HasErrors)
            {
                Editora editora = new Editora
                {
                    Nome = nome,
                    CNPJ = txtCNPJ.Text.Trim(),
                    Cidade = cidade,
                    AnoFundacao = anoFundacao,
                };

                try
                {
                    if (idEditar == null)
                        EditoraController.Salvar(editora);
                    else
                    {
                        editora.Id = idEditar.Value;
                        EditoraController.Atualizar(editora);
                    }
                    MessageBox.Show("Editora salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

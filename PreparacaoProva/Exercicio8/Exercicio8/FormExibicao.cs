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
    public partial class FormExibicao : formPadrao
    {
        private List<Usuario> usuarios;
        public FormExibicao(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
            InitializeComponent();
        }

        private void FormExibicao_Load(object sender, EventArgs e)
        {
            ddlSituacao.SelectedIndex = 0;
            dataGridView1.DataSource = usuarios;
        }

        private void ddlSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlSituacao.SelectedIndex == 0)
            {
                //todos os usuários
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = usuarios;
            }
            else if(ddlSituacao.SelectedIndex == 1)
            {
                //apenas ativos
                dataGridView1.DataSource = null;

                //var ativos =
                //    from Usuario u in usuarios
                //    where u.Situacao == "A"
                //    select u;

                var ativos = usuarios.Where(p => p.Situacao == "A");

                dataGridView1.DataSource = ativos.ToList();
            }
            else if(ddlSituacao.SelectedIndex == 2)
            {
                //apenas inativos
                dataGridView1.DataSource = null;

                var inativos = usuarios.Where(p => p.Situacao == "I");

                dataGridView1.DataSource = inativos.ToList();
            }
        }
    }
}

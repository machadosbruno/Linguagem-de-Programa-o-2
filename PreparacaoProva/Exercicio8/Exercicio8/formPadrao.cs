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
    public partial class formPadrao : Form
    {
        public formPadrao()
        {
            InitializeComponent();
        }

        protected void formPadrao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar o formulário", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.No)
                e.Cancel = true;
        }
    }
}

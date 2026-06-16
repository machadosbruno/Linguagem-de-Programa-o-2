namespace ProjetoBiblioteca.View
{
    partial class FormEditoraInserir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtCNPJ = new MaskedTextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtAnoFundacao = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAnoFundacao).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(437, 301);
            button1.Name = "button1";
            button1.Size = new Size(137, 37);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 7;
            label2.Text = "CNPJ";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(12, 42);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(562, 35);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCNPJ.Location = new Point(12, 113);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(562, 35);
            txtCNPJ.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 11;
            label3.Text = "Cidade da sede";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.Location = new Point(12, 184);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(562, 35);
            txtCidade.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 222);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 13;
            label4.Text = "Ano de fundação";
            // 
            // txtAnoFundacao
            // 
            txtAnoFundacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnoFundacao.Location = new Point(12, 255);
            txtAnoFundacao.Name = "txtAnoFundacao";
            txtAnoFundacao.Size = new Size(562, 35);
            txtAnoFundacao.TabIndex = 3;
            txtAnoFundacao.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // FormEditoraInserir
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 350);
            Controls.Add(txtAnoFundacao);
            Controls.Add(label4);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtCNPJ);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormEditoraInserir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Editora";
            Load += FormEditoraInserir_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAnoFundacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private ErrorProvider errorProvider1;
        private NumericUpDown txtAnoFundacao;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private MaskedTextBox txtCNPJ;
    }
}
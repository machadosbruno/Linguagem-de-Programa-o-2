namespace ProjetoBiblioteca.View
{
    partial class FormLivroInserir
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
            dtpDataPublicacao = new DateTimePicker();
            lblNome = new Label();
            txtTitulo = new TextBox();
            lblDataPublicacao = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // dtpDataPublicacao
            // 
            dtpDataPublicacao.CustomFormat = "dd/MM/yyyy";
            dtpDataPublicacao.Format = DateTimePickerFormat.Custom;
            dtpDataPublicacao.ImeMode = ImeMode.NoControl;
            dtpDataPublicacao.Location = new Point(47, 123);
            dtpDataPublicacao.Name = "dtpDataPublicacao";
            dtpDataPublicacao.Size = new Size(268, 23);
            dtpDataPublicacao.TabIndex = 4;
            dtpDataPublicacao.Value = new DateTime(2026, 5, 19, 0, 0, 0, 0);
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(47, 50);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(37, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(47, 68);
            txtTitulo.MaxLength = 100;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(268, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblDataPublicacao
            // 
            lblDataPublicacao.AutoSize = true;
            lblDataPublicacao.Location = new Point(47, 105);
            lblDataPublicacao.Name = "lblDataPublicacao";
            lblDataPublicacao.Size = new Size(102, 15);
            lblDataPublicacao.TabIndex = 2;
            lblDataPublicacao.Text = "lblDataPublicacao";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(240, 152);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // FormLivroInserir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 202);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataPublicacao);
            Controls.Add(lblDataPublicacao);
            Controls.Add(txtTitulo);
            Controls.Add(lblNome);
            Name = "FormLivroInserir";
            Text = "Novo livro";
            Load += FormLivroInserir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtTitulo;
        private Label lblDataPublicacao;
        private DateTimePicker dtpDataPublicacao;
        private Button btnSalvar;
    }
}
namespace calendarios.View
{
    partial class CriarUsuario
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
            lblNome = new Label();
            txtNome = new TextBox();
            lbInformacao = new Label();
            picBoxUsuario = new PictureBox();
            btnSelecionarFoto = new Button();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(44, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 1;
            // 
            // lbInformacao
            // 
            lbInformacao.AutoSize = true;
            lbInformacao.Location = new Point(44, 22);
            lbInformacao.Name = "lbInformacao";
            lbInformacao.Size = new Size(240, 15);
            lbInformacao.TabIndex = 2;
            lbInformacao.Text = "Olá! Insisra seus dados para criar seu usuário";
            // 
            // picBoxUsuario
            // 
            picBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            picBoxUsuario.Location = new Point(44, 102);
            picBoxUsuario.Name = "picBoxUsuario";
            picBoxUsuario.Size = new Size(240, 219);
            picBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUsuario.TabIndex = 3;
            picBoxUsuario.TabStop = false;
            // 
            // btnSelecionarFoto
            // 
            btnSelecionarFoto.Location = new Point(44, 327);
            btnSelecionarFoto.Name = "btnSelecionarFoto";
            btnSelecionarFoto.Size = new Size(240, 23);
            btnSelecionarFoto.TabIndex = 4;
            btnSelecionarFoto.Text = "Selecionar foto";
            btnSelecionarFoto.UseVisualStyleBackColor = true;
            btnSelecionarFoto.Click += btnSelecionarFoto_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(44, 406);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // CriarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(btnSelecionarFoto);
            Controls.Add(picBoxUsuario);
            Controls.Add(lbInformacao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "CriarUsuario";
            Text = "CriarUsuario";
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lbInformacao;
        private PictureBox picBoxUsuario;
        private Button btnSelecionarFoto;
        private Button btnEntrar;
    }
}
namespace Exercicio8
{
    partial class FormCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            rdoSituacaoAtivo = new RadioButton();
            rdoSituacaoInativo = new RadioButton();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome de usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 0;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 0;
            label3.Text = "Situação";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 42);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(535, 35);
            txtUsername.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 112);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(535, 35);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // rdoSituacaoAtivo
            // 
            rdoSituacaoAtivo.AutoSize = true;
            rdoSituacaoAtivo.Location = new Point(12, 184);
            rdoSituacaoAtivo.Margin = new Padding(3, 4, 3, 4);
            rdoSituacaoAtivo.Name = "rdoSituacaoAtivo";
            rdoSituacaoAtivo.Size = new Size(79, 34);
            rdoSituacaoAtivo.TabIndex = 3;
            rdoSituacaoAtivo.TabStop = true;
            rdoSituacaoAtivo.Text = "Ativo";
            rdoSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // rdoSituacaoInativo
            // 
            rdoSituacaoInativo.AutoSize = true;
            rdoSituacaoInativo.Location = new Point(98, 184);
            rdoSituacaoInativo.Margin = new Padding(3, 4, 3, 4);
            rdoSituacaoInativo.Name = "rdoSituacaoInativo";
            rdoSituacaoInativo.Size = new Size(94, 34);
            rdoSituacaoInativo.TabIndex = 3;
            rdoSituacaoInativo.TabStop = true;
            rdoSituacaoInativo.Text = "Inativo";
            rdoSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(442, 216);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(105, 42);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 268);
            Controls.Add(button1);
            Controls.Add(rdoSituacaoInativo);
            Controls.Add(rdoSituacaoAtivo);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormCadastro";
            Text = "FormCadastro";
            FormClosing += FormCadastro_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtSenha;
        private RadioButton rdoSituacaoAtivo;
        private RadioButton rdoSituacaoInativo;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}
namespace Projeto_Faculdade
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        /// </param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.linkLabelCadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPERMERCADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(106, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre na sua conta";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUsuario.Location = new System.Drawing.Point(110, 117);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(224, 25);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.Text = "Usuario";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSenha.Location = new System.Drawing.Point(110, 148);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(224, 26);
            this.textBoxSenha.TabIndex = 3;
            this.textBoxSenha.Text = "Senha";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEntrar.Location = new System.Drawing.Point(110, 191);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(87, 29);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "ENTRAR";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.bnt_entrar);
            // 
            // linkLabelCadastrar
            // 
            this.linkLabelCadastrar.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelCadastrar.AutoSize = true;
            this.linkLabelCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelCadastrar.LinkColor = System.Drawing.Color.Black;
            this.linkLabelCadastrar.Location = new System.Drawing.Point(107, 233);
            this.linkLabelCadastrar.Name = "linkLabelCadastrar";
            this.linkLabelCadastrar.Size = new System.Drawing.Size(190, 17);
            this.linkLabelCadastrar.TabIndex = 6;
            this.linkLabelCadastrar.TabStop = true;
            this.linkLabelCadastrar.Text = "Não tem conta?Cadastrar-se";
            this.linkLabelCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bnt_cadastro_user);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Faculdade.Properties.Resources.pal;
            this.ClientSize = new System.Drawing.Size(454, 352);
            this.Controls.Add(this.linkLabelCadastrar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.LinkLabel linkLabelCadastrar;
    }
}
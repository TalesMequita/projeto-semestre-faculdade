namespace Projeto_Faculdade
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFaturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_caixa = new System.Windows.Forms.Button();
            this.btn_faturamento = new System.Windows.Forms.Button();
            this.btn_troca_usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.menuCadProdutos);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.menuCadCategoria);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVendas,
            this.itemFaturamento,
            this.itemEstoque});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatorioToolStripMenuItem.Text = "Relatórios";
            // 
            // itemVendas
            // 
            this.itemVendas.Name = "itemVendas";
            this.itemVendas.Size = new System.Drawing.Size(142, 22);
            this.itemVendas.Text = "Vendas";
            this.itemVendas.Click += new System.EventHandler(this.bnt_vendas);
            // 
            // itemFaturamento
            // 
            this.itemFaturamento.Name = "itemFaturamento";
            this.itemFaturamento.Size = new System.Drawing.Size(142, 22);
            this.itemFaturamento.Text = "Faturamento";
            this.itemFaturamento.Click += new System.EventHandler(this.bnt_Faturamento);
            // 
            // itemEstoque
            // 
            this.itemEstoque.Name = "itemEstoque";
            this.itemEstoque.Size = new System.Drawing.Size(142, 22);
            this.itemEstoque.Text = "Estoque";
            this.itemEstoque.Click += new System.EventHandler(this.bnt_estoque);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.White;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatAppearance.BorderSize = 2;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_produtos.Image = global::Projeto_Faculdade.Properties.Resources.cad_prod__75;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(116, 362);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(85, 95);
            this.btn_cad_produtos.TabIndex = 1;
            this.btn_cad_produtos.Text = "Cadastrar Produtos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.btn_cad_produtos_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatAppearance.BorderSize = 2;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_categorias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_categorias.Image = global::Projeto_Faculdade.Properties.Resources.categorias;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(236, 362);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(85, 95);
            this.btn_cad_categorias.TabIndex = 2;
            this.btn_cad_categorias.Text = "Cadastrar Categoria";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.BackColor = System.Drawing.Color.White;
            this.btn_encerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_encerrar.FlatAppearance.BorderSize = 2;
            this.btn_encerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_encerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_encerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_encerrar.Image = global::Projeto_Faculdade.Properties.Resources._2;
            this.btn_encerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_encerrar.Location = new System.Drawing.Point(475, 362);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Size = new System.Drawing.Size(85, 95);
            this.btn_encerrar.TabIndex = 3;
            this.btn_encerrar.Text = "Encerrar";
            this.btn_encerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_encerrar.UseVisualStyleBackColor = false;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_encerrar_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.Color.White;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estoque.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_estoque.FlatAppearance.BorderSize = 2;
            this.btn_estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.Image = global::Projeto_Faculdade.Properties.Resources.ca;
            this.btn_estoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_estoque.Location = new System.Drawing.Point(236, 229);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(85, 95);
            this.btn_estoque.TabIndex = 4;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_estoque.UseVisualStyleBackColor = false;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.BackColor = System.Drawing.Color.White;
            this.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatAppearance.BorderSize = 2;
            this.btn_vendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_vendas.Image = global::Projeto_Faculdade.Properties.Resources.pracheta1;
            this.btn_vendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vendas.Location = new System.Drawing.Point(475, 229);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(85, 95);
            this.btn_vendas.TabIndex = 5;
            this.btn_vendas.Text = "Pedidos";
            this.btn_vendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vendas.UseVisualStyleBackColor = false;
            this.btn_vendas.Click += new System.EventHandler(this.btn_pedidos);
            // 
            // btn_caixa
            // 
            this.btn_caixa.BackColor = System.Drawing.Color.White;
            this.btn_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caixa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_caixa.FlatAppearance.BorderSize = 2;
            this.btn_caixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_caixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_caixa.Image = global::Projeto_Faculdade.Properties.Resources.caixa_de_di;
            this.btn_caixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_caixa.Location = new System.Drawing.Point(116, 229);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Size = new System.Drawing.Size(85, 95);
            this.btn_caixa.TabIndex = 6;
            this.btn_caixa.Text = "Caixa";
            this.btn_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caixa.UseVisualStyleBackColor = false;
            this.btn_caixa.Click += new System.EventHandler(this.btn_caixa_Click);
            // 
            // btn_faturamento
            // 
            this.btn_faturamento.BackColor = System.Drawing.Color.White;
            this.btn_faturamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_faturamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_faturamento.FlatAppearance.BorderSize = 2;
            this.btn_faturamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_faturamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_faturamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_faturamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_faturamento.Image = global::Projeto_Faculdade.Properties.Resources.dinheiro;
            this.btn_faturamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_faturamento.Location = new System.Drawing.Point(355, 229);
            this.btn_faturamento.Name = "btn_faturamento";
            this.btn_faturamento.Size = new System.Drawing.Size(85, 95);
            this.btn_faturamento.TabIndex = 7;
            this.btn_faturamento.Text = "Faturamento";
            this.btn_faturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_faturamento.UseVisualStyleBackColor = false;
            this.btn_faturamento.Click += new System.EventHandler(this.btn_faturamento_Click);
            // 
            // btn_troca_usuario
            // 
            this.btn_troca_usuario.BackColor = System.Drawing.Color.White;
            this.btn_troca_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_troca_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_troca_usuario.FlatAppearance.BorderSize = 2;
            this.btn_troca_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_troca_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_troca_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_troca_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_troca_usuario.Image = global::Projeto_Faculdade.Properties.Resources.usuario;
            this.btn_troca_usuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_troca_usuario.Location = new System.Drawing.Point(355, 362);
            this.btn_troca_usuario.Name = "btn_troca_usuario";
            this.btn_troca_usuario.Size = new System.Drawing.Size(85, 95);
            this.btn_troca_usuario.TabIndex = 8;
            this.btn_troca_usuario.Text = "Trocar de Usuario";
            this.btn_troca_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_troca_usuario.UseVisualStyleBackColor = false;
            this.btn_troca_usuario.Click += new System.EventHandler(this.btn_troca_user);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(255, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "CENTRAL DO SUPERMERCADO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Projeto_Faculdade.Properties.Resources.download;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(597, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 95);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fornecedor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bnt_fornecedor);
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Image = global::Projeto_Faculdade.Properties.Resources.images;
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(226, 196);
            this.pictureBoxFotoPerfil.TabIndex = 32;
            this.pictureBoxFotoPerfil.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(257, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "BEM VINDO AO MENU";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Faculdade.Properties.Resources.pal;
            this.ClientSize = new System.Drawing.Size(784, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_troca_usuario);
            this.Controls.Add(this.btn_faturamento);
            this.Controls.Add(this.btn_caixa);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_estoque);
            this.Controls.Add(this.btn_encerrar);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_caixa;
        private System.Windows.Forms.Button btn_faturamento;
        private System.Windows.Forms.Button btn_troca_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemVendas;
        private System.Windows.Forms.ToolStripMenuItem itemFaturamento;
        private System.Windows.Forms.ToolStripMenuItem itemEstoque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Label label4;
    }
}


namespace Projeto_Faculdade
{
    partial class Form1
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
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.btn_cad_clientes = new System.Windows.Forms.Button();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_faturamento = new System.Windows.Forms.Button();
            this.btn_grafico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
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
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.White;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatAppearance.BorderSize = 2;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.Image = global::Projeto_Faculdade.Properties.Resources.cad_prod__75;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(96, 266);
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
            this.btn_cad_categorias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_categorias.Image = global::Projeto_Faculdade.Properties.Resources.categorias;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(216, 266);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(85, 95);
            this.btn_cad_categorias.TabIndex = 2;
            this.btn_cad_categorias.Text = "Cadastrar Categoria";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // btn_cad_clientes
            // 
            this.btn_cad_clientes.BackColor = System.Drawing.Color.White;
            this.btn_cad_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_clientes.FlatAppearance.BorderSize = 2;
            this.btn_cad_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_clientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_clientes.Image = global::Projeto_Faculdade.Properties.Resources._2;
            this.btn_cad_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_clientes.Location = new System.Drawing.Point(455, 266);
            this.btn_cad_clientes.Name = "btn_cad_clientes";
            this.btn_cad_clientes.Size = new System.Drawing.Size(85, 95);
            this.btn_cad_clientes.TabIndex = 3;
            this.btn_cad_clientes.Text = "Encerrar";
            this.btn_cad_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_clientes.UseVisualStyleBackColor = false;
            this.btn_cad_clientes.Click += new System.EventHandler(this.btn_cad_clientes_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.Color.White;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estoque.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_estoque.FlatAppearance.BorderSize = 2;
            this.btn_estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.Image = global::Projeto_Faculdade.Properties.Resources.ca;
            this.btn_estoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_estoque.Location = new System.Drawing.Point(216, 133);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(85, 95);
            this.btn_estoque.TabIndex = 4;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_estoque.UseVisualStyleBackColor = false;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.BackColor = System.Drawing.Color.White;
            this.btn_relatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_relatorios.FlatAppearance.BorderSize = 2;
            this.btn_relatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_relatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_relatorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_relatorios.Image = global::Projeto_Faculdade.Properties.Resources.pracheta1;
            this.btn_relatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_relatorios.Location = new System.Drawing.Point(455, 133);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(85, 95);
            this.btn_relatorios.TabIndex = 5;
<<<<<<< Updated upstream
            this.btn_relatorios.Text = "APAGAR";
=======
            this.btn_relatorios.Text = "Vendas";
>>>>>>> Stashed changes
            this.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_relatorios.UseVisualStyleBackColor = false;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.BackColor = System.Drawing.Color.White;
            this.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatAppearance.BorderSize = 2;
            this.btn_vendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_vendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_vendas.Image = global::Projeto_Faculdade.Properties.Resources.caixa_de_di;
            this.btn_vendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vendas.Location = new System.Drawing.Point(96, 133);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(85, 95);
            this.btn_vendas.TabIndex = 6;
            this.btn_vendas.Text = "Caixa Aberto";
            this.btn_vendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vendas.UseVisualStyleBackColor = false;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // btn_faturamento
            // 
            this.btn_faturamento.BackColor = System.Drawing.Color.White;
            this.btn_faturamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_faturamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_faturamento.FlatAppearance.BorderSize = 2;
            this.btn_faturamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_faturamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_faturamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_faturamento.Image = global::Projeto_Faculdade.Properties.Resources.dinheiro;
            this.btn_faturamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_faturamento.Location = new System.Drawing.Point(335, 133);
            this.btn_faturamento.Name = "btn_faturamento";
            this.btn_faturamento.Size = new System.Drawing.Size(85, 95);
            this.btn_faturamento.TabIndex = 7;
            this.btn_faturamento.Text = "Faturamento";
            this.btn_faturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_faturamento.UseVisualStyleBackColor = false;
            this.btn_faturamento.Click += new System.EventHandler(this.btn_faturamento_Click);
            // 
            // btn_grafico
            // 
            this.btn_grafico.BackColor = System.Drawing.Color.White;
            this.btn_grafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grafico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_grafico.FlatAppearance.BorderSize = 2;
            this.btn_grafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_grafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_grafico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_grafico.Image = global::Projeto_Faculdade.Properties.Resources.usuario;
            this.btn_grafico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_grafico.Location = new System.Drawing.Point(335, 266);
            this.btn_grafico.Name = "btn_grafico";
            this.btn_grafico.Size = new System.Drawing.Size(85, 95);
            this.btn_grafico.TabIndex = 8;
            this.btn_grafico.Text = "Trocar de Usuario";
            this.btn_grafico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_grafico.UseVisualStyleBackColor = false;
            this.btn_grafico.Click += new System.EventHandler(this.btn_grafico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(136, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "CENTRAL DE ATEDIMENTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Faculdade.Properties.Resources.pal;
            this.ClientSize = new System.Drawing.Size(667, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grafico);
            this.Controls.Add(this.btn_faturamento);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_relatorios);
            this.Controls.Add(this.btn_estoque);
            this.Controls.Add(this.btn_cad_clientes);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btn_cad_clientes;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_faturamento;
        private System.Windows.Forms.Button btn_grafico;
        private System.Windows.Forms.Label label1;
    }
}


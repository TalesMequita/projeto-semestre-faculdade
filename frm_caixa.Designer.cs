namespace Projeto_Faculdade
{
    partial class frm_caixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_prod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.bnt_confirmar = new System.Windows.Forms.Button();
            this.comboBoxFormaPag = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFaturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_adicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.preco_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(236, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAIXA DE ATENDIMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(455, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUANTIDADE";
            // 
            // nome_prod
            // 
            this.nome_prod.AutoSize = true;
            this.nome_prod.BackColor = System.Drawing.Color.Transparent;
            this.nome_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nome_prod.Location = new System.Drawing.Point(275, 124);
            this.nome_prod.Name = "nome_prod";
            this.nome_prod.Size = new System.Drawing.Size(269, 29);
            this.nome_prod.TabIndex = 2;
            this.nome_prod.Text = "NOME_DO_PRODUTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(216, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CODIGO";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(455, 219);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(111, 23);
            this.textBoxQuantidade.TabIndex = 6;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCodigo.Location = new System.Drawing.Point(220, 219);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(70, 23);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(110, 248);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.Size = new System.Drawing.Size(547, 172);
            this.dataGridViewCompras.TabIndex = 8;
            // 
            // bnt_confirmar
            // 
            this.bnt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bnt_confirmar.Location = new System.Drawing.Point(131, 446);
            this.bnt_confirmar.Name = "bnt_confirmar";
            this.bnt_confirmar.Size = new System.Drawing.Size(116, 26);
            this.bnt_confirmar.TabIndex = 9;
            this.bnt_confirmar.Text = "CONFIRMAR";
            this.bnt_confirmar.UseVisualStyleBackColor = true;
            this.bnt_confirmar.Click += new System.EventHandler(this.bnt_confirmar_Click);
            // 
            // comboBoxFormaPag
            // 
            this.comboBoxFormaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFormaPag.FormattingEnabled = true;
            this.comboBoxFormaPag.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Boleto",
            "Dinheiro"});
            this.comboBoxFormaPag.Location = new System.Drawing.Point(280, 444);
            this.comboBoxFormaPag.Name = "comboBoxFormaPag";
            this.comboBoxFormaPag.Size = new System.Drawing.Size(197, 28);
            this.comboBoxFormaPag.TabIndex = 11;
            this.comboBoxFormaPag.Text = "Nenhuma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(283, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "FORMA DE PAGAMENTO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cadastroToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItem1.Text = "Menu Principal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.bnt_menu_principal);
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
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.bnt_cad_produtos);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.bnt_cad_categoria);
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
            this.itemVendas.Click += new System.EventHandler(this.bnt_relat_vendas);
            // 
            // itemFaturamento
            // 
            this.itemFaturamento.Name = "itemFaturamento";
            this.itemFaturamento.Size = new System.Drawing.Size(142, 22);
            this.itemFaturamento.Text = "Faturamento";
            this.itemFaturamento.Click += new System.EventHandler(this.bnt_relat_faturamento);
            // 
            // itemEstoque
            // 
            this.itemEstoque.Name = "itemEstoque";
            this.itemEstoque.Size = new System.Drawing.Size(142, 22);
            this.itemEstoque.Text = "Estoque";
            this.itemEstoque.Click += new System.EventHandler(this.bnt_relat_estoque);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 105);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // bnt_adicionar
            // 
            this.bnt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bnt_adicionar.Location = new System.Drawing.Point(663, 248);
            this.bnt_adicionar.Name = "bnt_adicionar";
            this.bnt_adicionar.Size = new System.Drawing.Size(116, 26);
            this.bnt_adicionar.TabIndex = 33;
            this.bnt_adicionar.Text = "ADICIONAR";
            this.bnt_adicionar.UseVisualStyleBackColor = true;
            this.bnt_adicionar.Click += new System.EventHandler(this.bnt_adicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(507, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "TOTAL:";
            // 
            // preco_total
            // 
            this.preco_total.AutoSize = true;
            this.preco_total.BackColor = System.Drawing.Color.Transparent;
            this.preco_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.preco_total.Location = new System.Drawing.Point(576, 452);
            this.preco_total.Name = "preco_total";
            this.preco_total.Size = new System.Drawing.Size(61, 20);
            this.preco_total.TabIndex = 35;
            this.preco_total.Text = "R$0.00";
            // 
            // frm_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Faculdade.Properties.Resources.pal;
            this.ClientSize = new System.Drawing.Size(786, 513);
            this.Controls.Add(this.preco_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnt_adicionar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFormaPag);
            this.Controls.Add(this.bnt_confirmar);
            this.Controls.Add(this.dataGridViewCompras);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nome_prod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA DE ATENDIMENTO";
            this.Load += new System.EventHandler(this.frm_caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nome_prod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.Button bnt_confirmar;
        private System.Windows.Forms.ComboBox comboBoxFormaPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemVendas;
        private System.Windows.Forms.ToolStripMenuItem itemFaturamento;
        private System.Windows.Forms.ToolStripMenuItem itemEstoque;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnt_adicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label preco_total;
    }
}
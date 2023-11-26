namespace Projeto_Faculdade
{
    partial class frm_produtos
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFaturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_custo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_validade = new System.Windows.Forms.DateTimePicker();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nome.Location = new System.Drawing.Point(141, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(436, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_valor.Location = new System.Drawing.Point(141, 191);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(154, 26);
            this.txt_valor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(503, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORIA";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cadastrar.Location = new System.Drawing.Point(160, 332);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(120, 33);
            this.btn_cadastrar.TabIndex = 7;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.bnt_cad_produto);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_excluir.Location = new System.Drawing.Point(286, 332);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(108, 33);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.bnt_excluir);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(19, 371);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(636, 161);
            this.dataGridViewProdutos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(154, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "CADASTRO DE PRODUTOS";
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
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 14;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "VALIDADE:";
            // 
            // txt_custo
            // 
            this.txt_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_custo.Location = new System.Drawing.Point(141, 159);
            this.txt_custo.Name = "txt_custo";
            this.txt_custo.Size = new System.Drawing.Size(154, 26);
            this.txt_custo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "CUSTO:";
            // 
            // date_validade
            // 
            this.date_validade.Cursor = System.Windows.Forms.Cursors.Default;
            this.date_validade.CustomFormat = "9999/12/31";
            this.date_validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date_validade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_validade.Location = new System.Drawing.Point(141, 127);
            this.date_validade.MinDate = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            this.date_validade.Name = "date_validade";
            this.date_validade.Size = new System.Drawing.Size(154, 26);
            this.date_validade.TabIndex = 19;
            this.date_validade.ValueChanged += new System.EventHandler(this.date_validade_ValueChanged);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_quantidade.Location = new System.Drawing.Point(141, 223);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(154, 26);
            this.txt_quantidade.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(16, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "QUANTIDADE:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpar.Location = new System.Drawing.Point(400, 332);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(106, 33);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.bnt_cancelar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(16, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "FONECEDOR:";
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.ItemHeight = 20;
            this.listBoxCategoria.Items.AddRange(new object[] {
            "Nenhuma"});
            this.listBoxCategoria.Location = new System.Drawing.Point(450, 159);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(195, 124);
            this.listBoxCategoria.TabIndex = 24;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(141, 259);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(154, 28);
            this.cb_fornecedor.TabIndex = 26;
            this.cb_fornecedor.Text = "Nenhum";
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Faculdade.Properties.Resources.pal;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.cb_fornecedor);
            this.Controls.Add(this.listBoxCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_validade);
            this.Controls.Add(this.txt_custo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "frm_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.frm_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemVendas;
        private System.Windows.Forms.ToolStripMenuItem itemFaturamento;
        private System.Windows.Forms.ToolStripMenuItem itemEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_custo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_validade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxCategoria;
        private System.Windows.Forms.ComboBox cb_fornecedor;
    }
}
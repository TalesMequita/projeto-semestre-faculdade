using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Projeto_Faculdade
{
    public partial class frm_menu : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e) // Botão de cadastro de produtos
        {
            frm_produtos frm = new frm_produtos();

            if(this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_faturamento_Click(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {

        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            frm_encerrar frm = new frm_encerrar();

            frm.ShowDialog();
        }

        private void menuCadProdutos(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos ();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void menuCadCategoria(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_vendas(object sender, EventArgs e)
        {
            frm_consulta_pedido frm = new frm_consulta_pedido();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_Faturamento(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_estoque(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_troca_user(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();

            if(this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();

        }

        private void bnt_fornecedor(object sender, EventArgs e)
        {
            frm_fornecedor frm = new frm_fornecedor();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void btn_pedidos(object sender, EventArgs e)
        {
            frm_consulta_pedido frm = new frm_consulta_pedido();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }
    }
}

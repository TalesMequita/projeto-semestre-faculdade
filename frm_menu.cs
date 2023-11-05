using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Faculdade
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        // Abaixo estão os botões responsaveis por navegar para as outras páginas

        private void btn_cad_produtos_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de cadastro de produtos
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

        private void btn_cad_categorias_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de cadastro de categorias
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_faturamento_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de faturamento
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_estoque_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de estoque
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_vendas_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de vendas
        {
            frm_vendas frm = new frm_vendas();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_caixa_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de caixa/atendente
        {
            frm_caixa frm = new frm_caixa();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_troca_user_Click(object sender, EventArgs e) // Botão responsavel por ir a aba de login e fazer a troca de usuario
        {
            frm_login frm = new frm_login();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void btn_encerrar_Click(object sender, EventArgs e) // Botão responsavel por encerrar o aplicativo
        {
            frm_alert_encerrar frm = new frm_alert_encerrar();

            frm.ShowDialog();
        }


        // Daqui pra baixo é configuração para os botões de menu
        // Sendo está primeira fileira para os botões de cadastros

        private void menuCadProduto(object sender, EventArgs e) // Botão de cadastro dos produtos
        {
            frm_produtos frm = new frm_produtos();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void menuCadCategoria(object sender, EventArgs e) // Botão de cadastro das categorias
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        // Daqui para baixo são os botões de relatório

        private void menuRelatEstoque(object sender, EventArgs e) // Botão de relatório dos estoques
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void menuRelatVendas(object sender, EventArgs e) // Botão de relatório das vendas
        {
            frm_vendas frm = new frm_vendas();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void menuRelatFaturamento(object sender, EventArgs e) // Botão responsavel por relatório de faturamento
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

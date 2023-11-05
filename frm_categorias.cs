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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void bnt_voltar(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {

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

            Application.Exit();
        }

        private void menuCadCategoria(object sender, EventArgs e) // Botão de cadastro das categorias
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
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

            Application.Exit();
        }

        private void menuRelatVendas(object sender, EventArgs e) // Botão de relatório das vendas
        {
            frm_vendas frm = new frm_vendas();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void menuRelatFaturamento(object sender, EventArgs e) // Botão responsavel por relatório de faturamento
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }
>>>>>>> Stashed changes
    }
}

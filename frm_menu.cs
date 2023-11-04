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

        private void btn_cad_produtos_Click(object sender, EventArgs e) //Botão de cadastro de produtos
        {
            frm_produtos frm = new frm_produtos();

            if(this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
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

            Application.Exit();
        }

        private void btn_faturamento_Click(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frm_vendas frm = new frm_vendas();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void btn_troca_user_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            Application.Exit();
        }
    }
}

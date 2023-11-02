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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e) //Cadastro de produtos
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void btn_faturamento_Click(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();    
            frm.Show(); 
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();    
            frm.Show();
        }

        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            frm_relatorios frm = new frm_relatorios();      
            frm.Show(); 
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();  
            frm.Show();
        }

        private void btn_grafico_Click(object sender, EventArgs e)
        {
            frm_grafico_produtos frm = new frm_grafico_produtos(); 
            frm.Show(); 
        }

        private void btn_cad_clientes_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes();  
            frm.Show(); 
        }
    }
}

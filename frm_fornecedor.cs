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
    public partial class frm_fornecedor : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_fornecedor()
        {
            InitializeComponent();
        }

        private void bnt_consultar(object sender, EventArgs e)
        {
            frm_consulta_fornecedores frm = new frm_consulta_fornecedores();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();  

            if (this.Visible) 
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
        
            if (this.Visible) 
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();      

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog(); 
            this.Close();
        }

        private void itemVendas_Click(object sender, EventArgs e)
        {
            frm_consulta_pedido frm = new frm_consulta_pedido();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void itemFaturamento_Click(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void itemEstoque_Click(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO fornecedor (nome,CNPJ,telefone,representante) " +
                            "VALUES " + "('" + txtNomeFornecedor.Text + "', '" + txtCNPJ.Text + "', '" + txtTelefone.Text + "', '" + txtRepresentante.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open(); 
                comando.ExecuteReader();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");

            } catch (Exception ex)  
            { 
                MessageBox.Show("erro: " + ex.Message);
            } finally 
            { 
                Conexao.Close();
            }
        }
    }
}

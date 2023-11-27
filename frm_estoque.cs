using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto_Faculdade
{
    public partial class frm_estoque : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_estoque()
        {
            InitializeComponent();
        }

        private void bnt_menu_principal(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_cad_produtos(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_cad_categoria(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_relat_vendas(object sender, EventArgs e)
        {
            frm_consulta_pedido frm = new frm_consulta_pedido();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_relat_faturamento(object sender, EventArgs e)
        {
            frm_faturamento frm = new frm_faturamento();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void bnt_relat_estoque(object sender, EventArgs e)
        {
            frm_estoque frm = new frm_estoque();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string nomeBusca = string.IsNullOrWhiteSpace(txtNome.Text) ? "%" : "%" + txtNome.Text + "%";
                string sql = "SELECT * FROM produto WHERE nome LIKE @nome";

                Conexao.Open();

                DataTable dt = new DataTable();
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nome", nomeBusca);
                    da.Fill(dt);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarDataGridView()
        {
            
        }

        private void frm_estoque_Load(object sender, EventArgs e)
        {
            
            MySqlConnection conexao = new MySqlConnection(data_source);

        }
        private void Limpar()
        {
            txtNome.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
        
}

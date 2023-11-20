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
    public partial class frm_categorias : Form
    {
        MySqlConnection Conexao;
        public frm_categorias()
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

        private void bnt_cad_produto(object sender, EventArgs e)
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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

                //Criar conexao cm MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "Insert Into categoria (nome)" + "Values" + "('" + txt_categoria + "')";

                //Executar o comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Categoria cadastrada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar com o BD " + ex.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}

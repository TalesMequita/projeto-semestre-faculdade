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
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

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
                //Criar conexao cm MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "Insert Into categoria (nome)" + "Values" + "('" + txt_categoria.Text + "')";

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "%" + txt_categoria.Text + "%";

                //Criar conexao cm MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM categoria WHERE nome LIKE @parametro";

                Conexao.Open();

                //Executar o comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@parametro", q);

                MySqlDataReader reader = comando.ExecuteReader();

                dataGridView1.ClearSelection(); // Limpar as linhas existentes no DataGridView

               while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                    };
                    dataGridView1.Rows.Add(row);    
                }
  
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            } finally 
            { 
                Conexao.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

                try
                {
                    // Obtém o valor da coluna "nome" da linha selecionada
                    string nomeParaExcluir = txt_categoria.Text.Trim();

                    //Criar conexao cm MySQL
                    Conexao = new MySqlConnection(data_source);

                if (string.IsNullOrEmpty(nomeParaExcluir) ) 
                {
                    MessageBox.Show("Por favor, insira um nome para exluir");
                    return; 
                }

                    using (MySqlConnection conexao = new MySqlConnection(data_source))
                    {
                        conexao.Open();

                        // Cria a consulta DELETE
                        string sqlDelete = "DELETE FROM categoria WHERE nome = @parametro";

                        using (MySqlCommand comandoDelete = new MySqlCommand(sqlDelete, conexao))
                        {
                            comandoDelete.Parameters.AddWithValue("@parametro", nomeParaExcluir);
                            int linhasAfetadas = comandoDelete.ExecuteNonQuery();

                            if (linhasAfetadas > 0 )
                            {
                                MessageBox.Show("Categoria excluida com succeso!");
                            } else
                            {
                                MessageBox.Show("Nenhuma categoria foi excluida, verifique o nome.");
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a categoria " + ex.Message);
                }
                
            
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_categoria.Clear();
            dataGridView1.Rows.Clear();   
        }
    }
}

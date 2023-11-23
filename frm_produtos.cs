using MySql.Data.MySqlClient;
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
    public partial class frm_produtos : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_produtos()
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

        // Classe para criar, manipualar e apagar os produtos:

        public class Produto
        {
            public string Nome { get; set; }
            public string Valor { get; set; }
            public string Quantidade { get; set; }
            public string Categoria { get; set; }
            public string Marca { get; set; }
            public DateTime Validade { get; set; }
        }

        // Criando a Lista e definindo como BindingList para que o dataGridView
        private BindingList<Produto> listaProdutos = new BindingList<Produto>();

        // Função que vai coletar os dados, adicionar em uma lista e exibir no dataGridView
        private void bnt_cad_produto(object sender, EventArgs e)
        {

            try
            {
                // Conectando com MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd_cadProduto = new MySqlCommand();

                cmd_cadProduto.Connection = Conexao;

                cmd_cadProduto.CommandText = "INSERT INTO produto (nome, quantidade, validade, custo, preco, fornecedor_nome)" +
                                             "VALUES " + "(@nome, @quantidade, @validade, @custo, @preco, @fornecedor_nome)";

                cmd_cadProduto.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd_cadProduto.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
                cmd_cadProduto.Parameters.AddWithValue("@validade", date_validade.Value.ToString("yyyy/MM-dd"));
                cmd_cadProduto.Parameters.AddWithValue("@custo", float.Parse(txt_custo.Text));
                cmd_cadProduto.Parameters.AddWithValue("@preco", float.Parse(txt_valor.Text));
                cmd_cadProduto.Parameters.AddWithValue("@fornecedor_nome", cb_fornecedor.Text);

                cmd_cadProduto.Prepare();
                cmd_cadProduto.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

            /*// Pegando os valores inseridos:
            string nome = textBoxNome.Text;
            string marca = textBoxMarca.Text;
            string valor = textBoxValor.Text;
            string quantidade = textBoxQuantidade.Text;
            DateTime validade = dateTimePickerValidade.Value;

            // Criando um objeto e inserindo as variaveis nele:
            Produto produto = new Produto
            {
                Nome = nome,
                Valor = valor,
                Quantidade = quantidade,
                Marca = marca,
                Validade = validade
            };

            // Adicionando o objeto a uma lista
            listaProdutos.Add(produto);

            // Exibindo a lista no dataGridView
            dataGridViewProdutos.DataSource = listaProdutos;*/
        }

        // Botão de cancelamento, em que vai limpar as caixas e valores dos textBox e dataTimePicker
        private void bnt_cancelar(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_custo.Clear();
            txt_valor.Clear();
            txt_quantidade.Clear();
            date_validade.Value = DateTime.Now; // Definindo para a data de hoje
        }

        // Botão de excluir que vai coletar a linha em que você clicar do dataGridView e apagar ela:
        private void bnt_excluir(object sender, EventArgs e)
        {
            // Verificando se você clicou em uma linha
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                // Recebendo a linha
                DataGridViewRow linhaSelecionada = dataGridViewProdutos.SelectedRows[0];

                // Recebendo os valores da linha
                Produto produtoSelecionado = (Produto)linhaSelecionada.DataBoundItem;

                // Removendo da lista de produtos aquela linha selecionada
                listaProdutos.Remove(produtoSelecionado);

                // Atualizando o dataGridView
                dataGridViewProdutos.DataSource = listaProdutos;
            }
            else
            {
                // Mensagem caso a pessoa não tenha clicado em nenhuma linha
                MessageBox.Show("Selecione um produto para excluir");
            }
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            PreencherComboBox();
        }
        private void PreencherComboBox()
        {
            MySqlConnection Conexao = new MySqlConnection(data_source);

            string vqueryCargo = @"SELECT nome FROM fornecedor ORDER BY id";

            MySqlCommand command = new MySqlCommand(vqueryCargo, Conexao);

            try
            {
                Conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string valor = reader["nome"].ToString();
                    cb_fornecedor.Items.Add(valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void date_validade_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

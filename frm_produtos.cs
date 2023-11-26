using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Faculdade.frm_caixa;

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

        // Classe para criar, manipular e apagar os produtos:
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
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    conexao.Open();

                    string nomeFornecedor = cb_fornecedor.Text;

                    int idFornecedor = ObterIdForn(nomeFornecedor);

                    if (idFornecedor != -1) { 
                        using (MySqlCommand cmd_cadProduto = new MySqlCommand())
                        {
                            cmd_cadProduto.Connection = conexao;

                            cmd_cadProduto.CommandText = "INSERT INTO produto (nome, quantidade, validade, preco, id_fornecedor)" +
                                                         "VALUES (@nome, @quantidade, @validade, @preco, @fornecedor)";
                            cmd_cadProduto.Parameters.AddWithValue("@nome", txt_nome.Text);
                            cmd_cadProduto.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txt_quantidade.Text));
                            cmd_cadProduto.Parameters.AddWithValue("@validade", date_validade.Value.ToString("yyyy/MM/dd"));
                            cmd_cadProduto.Parameters.AddWithValue("@preco", decimal.Parse(txt_valor.Text));
                            cmd_cadProduto.Parameters.AddWithValue("@fornecedor", idFornecedor);
                            

                            cmd_cadProduto.Prepare();
                            cmd_cadProduto.ExecuteNonQuery();
                        }

                        using (MySqlCommand insertIdProduroCategoria = new MySqlCommand())
                        {
                            insertIdProduroCategoria.Connection = conexao;

                            // Pega o id de Produto
                            string nomeProduto = (txt_nome.Text);
                            int idProduto = ProcurarProduto(nomeProduto);

                            // Pega o id de Categoria
                            string nomeCategoria = (listBoxCategoria.Text);
                            int idCategoria = ProcurarCategoria(nomeCategoria);

                            insertIdProduroCategoria.CommandText = "INSERT INTO produto_categoria(codigo_produto, id_categoria) VALUES (@codigo_produto, @id_categoria)";
                            insertIdProduroCategoria.Parameters.AddWithValue("@codigo_produto", idProduto);
                            insertIdProduroCategoria.Parameters.AddWithValue("@id_categoria", idCategoria);

                            insertIdProduroCategoria.Prepare();
                            insertIdProduroCategoria.ExecuteNonQuery();
                        }

                        AtualizarDataGridView();
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCaixas();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
        // Pega o id da categoria para inserir na tabela produto_categoria
        private int ProcurarCategoria(string nomeCategoria)
        {
            try
            {
                string query = @"SELECT id_categoria FROM categoria WHERE nome = @nomeCategoria;";

                using (MySqlCommand command = new MySqlCommand(query, Conexao))
                {
                    command.Parameters.AddWithValue("@nomeCategoria", nomeCategoria);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao tentar encontrar a categoria {error.message}");
                return -1;
            }
        }
        // Pega id do produto para inserir na tabela categoria_produto
        private int ProcurarProduto(string nomeProduto)
        {
            try
            {
                string query = @"SELECT codigo_produto FROM produto WHERE nome = @nomeProduto;";

                using (MySqlCommand command = new MySqlCommand(query, Conexao))
                {
                    command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao tentar encontrar o produto {error.message}");
                return -1;
            } 
        }

        // Pega id do fornecedor para inserir na tabela produto
        private int ObterIdForn(string nomeFornecedor)
        {
            try
            {
                string query = @"SELECT id_fornecedor FROM fornecedor WHERE nome = @nomeFornecedor;";

                using (MySqlCommand command = new MySqlCommand(query, Conexao))
                {
                    command.Parameters.AddWithValue("@nomeFornecedor", nomeFornecedor.ToString());

                    var result = command.ExecuteScalar();

                    if(result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao obter id do fornecedor: {erro.Message}");
                return -1;
            }
        }


        private void AtualizarDataGridView()
        {
            string sqlSelect = @"SELECT * FROM produto;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSelect, data_source))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewProdutos.DataSource = table;
            }
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            // Adicione esta linha para instanciar o objeto Conexao
            Conexao = new MySqlConnection(data_source);
            
            AtualizarDataGridView();

            PreencherComboBox();
        }

        private void LimparCaixas()
        {
            txt_nome.Clear();
            txt_custo.Clear();
            txt_valor.Clear();
            txt_quantidade.Clear();
            date_validade.Value = DateTime.Now; // Definindo para a data de hoje
        }

        // Botão de cancelamento, em que vai limpar as caixas e valores dos textBox e dataTimePicker
        private void bnt_cancelar(object sender, EventArgs e)
        {
            LimparCaixas();
        }

        // Botão de excluir que vai coletar a linha em que você clicar do dataGridView e apagar ela:
        private void bnt_excluir(object sender, EventArgs e)
        {
            // Verificando se você clicou em uma linha
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                // Recebendo a linha
                DataGridViewRow linhaSelecionada = dataGridViewProdutos.SelectedRows[0];

                // Obtendo os valores das colunas necessárias
                string nomeProduto = linhaSelecionada.Cells["Nome"].Value.ToString();
                string quantidadeProduto = linhaSelecionada.Cells["Quantidade"].Value.ToString();
                DateTime validadeProduto = Convert.ToDateTime(linhaSelecionada.Cells["Validade"].Value);

                // Removendo da lista de produtos aquela linha selecionada
                Produto produtoSelecionado = listaProdutos.FirstOrDefault(p =>
                    p.Nome == nomeProduto &&
                    p.Quantidade == quantidadeProduto &&
                    p.Validade == validadeProduto);

                listaProdutos.Remove(produtoSelecionado);

                // Excluindo do banco de dados
                ExcluirProdutoDoBanco(nomeProduto, Convert.ToInt32(quantidadeProduto), validadeProduto);

                // Atualizando o dataGridView
                AtualizarDataGridView();
            }
            else
            {
                // Mensagem caso a pessoa não tenha clicado em nenhuma linha
                MessageBox.Show("Selecione um produto para excluir");
            }
        }

        private void ExcluirProdutoDoBanco(string nomeProduto, int quantidadeProduto, DateTime validadeProduto)
        {
            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand cmd_excluirProduto = new MySqlCommand())
                    {
                        cmd_excluirProduto.Connection = conexao;
                        cmd_excluirProduto.CommandText = "DELETE FROM produto WHERE nome = @nome AND quantidade = @quantidade AND validade = @validade";
                        cmd_excluirProduto.Parameters.AddWithValue("@nome", nomeProduto);
                        cmd_excluirProduto.Parameters.AddWithValue("@quantidade", quantidadeProduto);
                        cmd_excluirProduto.Parameters.AddWithValue("@validade", validadeProduto);

                        cmd_excluirProduto.Prepare();
                        cmd_excluirProduto.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto excluído do banco de dados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreencherComboBox()
        {
            MySqlConnection conexao = new MySqlConnection(data_source);

            string queryFornecedor = @"SELECT nome FROM fornecedor ORDER BY id_fornecedor;";

            try
            {
                conexao.Open();

                MySqlCommand command = new MySqlCommand(queryFornecedor, conexao);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string valor = reader["nome"].ToString();
                        cb_fornecedor.Items.Add(valor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void date_validade_ValueChanged(object sender, EventArgs e)
        {
            // Se desejar fazer algo quando o valor da data for alterado, coloque o código aqui.
        }
    }
}

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
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";
        private MySqlConnection Conexao;
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
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {
                    Conexao.Open();

                    string nomeFornecedor = cb_fornecedor.Text;

                    int idFornecedor = ObterIdForn(nomeFornecedor);

                    if (idFornecedor != -1)
                    {
                        int idProduto = InserirProduto(Conexao, idFornecedor);

                        if (idProduto != -1)
                        {
                            int idCategoria = ProcurarCategoria(ObterCategoriaSelecionada());

                            if (idCategoria != -1)
                            {
                                InserirProdutoCategoria(Conexao, idProduto, idCategoria);

                                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AtualizarDataGridView();
                                LimparCaixas();
                            }
                            else
                            {
                                MessageBox.Show("Categoria não encontrada", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar o produto", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void AtualizarListBoxCategorias()
        {
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {
                    Conexao.Open();

                    string queryCategorias = "SELECT nome FROM categoria;";

                    using (MySqlCommand command = new MySqlCommand(queryCategorias, Conexao))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBoxCategoria.Items.Clear(); // Limpa os itens existentes

                            while (reader.Read())
                            {
                                string categoria = reader["nome"].ToString();
                                listBoxCategoria.Items.Add(categoria);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObterCategoriaSelecionada()
        {
            if (listBoxCategoria.SelectedItem != null)
            {
                return listBoxCategoria.SelectedItem.ToString();
            }

            return string.Empty;
        }

        private int InserirProduto(MySqlConnection Conexao, int idFornecedor)
        {
            try
            {
                using (MySqlCommand cmd_cadProduto = new MySqlCommand())
                {
                    cmd_cadProduto.Connection = Conexao;

                    cmd_cadProduto.CommandText = "INSERT INTO produto (nome, quantidade, validade, preco, id_fornecedor)" +
                                                 "VALUES (@nome, @quantidade, @validade, @preco, @fornecedor);";
                    cmd_cadProduto.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd_cadProduto.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txt_quantidade.Text));
                    cmd_cadProduto.Parameters.AddWithValue("@validade", date_validade.Value.ToString("yyyy/MM/dd"));
                    cmd_cadProduto.Parameters.AddWithValue("@preco", decimal.Parse(txt_valor.Text));
                    cmd_cadProduto.Parameters.AddWithValue("@fornecedor", idFornecedor);

                    cmd_cadProduto.Prepare();
                    cmd_cadProduto.ExecuteNonQuery();

                    // Obter o ID do último produto inserido
                    cmd_cadProduto.CommandText = "SELECT LAST_INSERT_ID()";
                    var result = cmd_cadProduto.ExecuteScalar();

                    if (result != null)
                    {
                        AtualizarDataGridView();
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        private void InserirProdutoCategoria(MySqlConnection Conexao, int idProduto, int idCategoria)
        {
            try
            {
                using (MySqlCommand insertIdProduroCategoria = new MySqlCommand())
                {
                    insertIdProduroCategoria.Connection = Conexao;

                    insertIdProduroCategoria.CommandText = "INSERT INTO produto_categoria(codigo_produto, id_categoria) VALUES (@codigo_produto, @id_categoria)";
                    insertIdProduroCategoria.Parameters.AddWithValue("@codigo_produto", idProduto);
                    insertIdProduroCategoria.Parameters.AddWithValue("@id_categoria", idCategoria);

                    insertIdProduroCategoria.Prepare();
                    insertIdProduroCategoria.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao cadastrar na tabela produto_categoria: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Pega o id da categoria para inserir na tabela produto_categoria
        private int ProcurarCategoria(string nomeCategoria)
        {
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {

                    Conexao.Open();
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
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao tentar encontrar a categoria: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        
        // Pega id do fornecedor para inserir na tabela produto
        private int ObterIdForn(string nomeFornecedor)
        {
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {
                    Conexao.Open();
                    string query = @"SELECT id_fornecedor FROM fornecedor WHERE nome = @nomeFornecedor;";

                    using (MySqlCommand command = new MySqlCommand(query, Conexao))
                    {
                        command.Parameters.AddWithValue("@nomeFornecedor", nomeFornecedor.ToString());

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
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao obter id do fornecedor: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }



        private void AtualizarDataGridView()
        {
            string sqlSelect = @"SELECT * FROM produto;";

            using (MySqlDataAdapter Conexao = new MySqlDataAdapter(sqlSelect, data_source))
            {
                DataTable table = new DataTable();
                Conexao.Fill(table);
                dataGridViewProdutos.DataSource = table;
            }
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);

            AtualizarDataGridView();
            AtualizarListBoxCategorias();

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
            try { 
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
            } catch(Exception error) 
            {
                MessageBox.Show($"Erro ao apagar o produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void ExcluirProdutoDoBanco(string nomeProduto, int quantidadeProduto, DateTime validadeProduto)
        {
            using (MySqlConnection Conexao = new MySqlConnection(data_source))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd_excluirProduto = new MySqlCommand())
                    {
                        cmd_excluirProduto.Connection = Conexao;
                        cmd_excluirProduto.CommandText = "DELETE FROM produto WHERE nome = @nome AND quantidade = @quantidade AND validade = @validade";
                        cmd_excluirProduto.Parameters.AddWithValue("@nome", nomeProduto);
                        cmd_excluirProduto.Parameters.AddWithValue("@quantidade", quantidadeProduto);
                        cmd_excluirProduto.Parameters.AddWithValue("@validade", validadeProduto);

                        cmd_excluirProduto.Prepare();
                        cmd_excluirProduto.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto excluído do banco de dados.");
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao excluir produto do banco de dados: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreencherComboBox()
        {
            MySqlConnection Conexao = new MySqlConnection(data_source);

            string queryFornecedor = @"SELECT nome FROM fornecedor ORDER BY id_fornecedor;";

            try
            {
                Conexao.Open();

                MySqlCommand command = new MySqlCommand(queryFornecedor, Conexao);

                List<string> listaDeFornecedores = new List<string>();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string valor = reader["nome"].ToString();
                        listaDeFornecedores.Add(valor);
                    }
                }

                cb_fornecedor.DataSource = listaDeFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Se desejar fazer algo quando o valor da data for alterado, coloque o código aqui.
        }
    }
}

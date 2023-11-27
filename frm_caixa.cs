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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Ocsp;

namespace Projeto_Faculdade
{
    public partial class frm_caixa : Form
    {
        private BindingList<ProdutoCategoria> produtosCategorias = new BindingList<ProdutoCategoria>();
        private BindingList<ProdutoCodigo> produtosCodigos = new BindingList<ProdutoCodigo>();
        private void bnt_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=db_pjsistema;User ID=root;Password=1234567;Charset=utf8";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlSelectCaixa = @"select p.codigo_produto, p.nome AS nome_produto, p.preco, c.id_categoria, c.nome AS nome_categoria from produto_categoria pc JOIN produto p ON pc.codigo_produto = p.codigo_produto JOIN categoria c ON pc.id_categoria = c.id_categoria WHERE p.codigo_produto = @codigo;";

                    using (MySqlCommand command = new MySqlCommand(sqlSelectCaixa, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);

                        var codigo = Convert.ToInt32(textBoxCodigo.Text);
                        ProdutoCodigo produtoCodigo = new ProdutoCodigo { CodigoProdutoList = codigo };
                        produtosCodigos.Add(produtoCodigo);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                ProdutoCategoria produtoCategoria = new ProdutoCategoria
                                {
                                    CodigoProduto = reader["codigo_produto"].ToString(),
                                    NomeProduto = reader["nome_produto"].ToString(),
                                    Quantidade = Convert.ToInt32(textBoxQuantidade.Text),
                                    Preco = Convert.ToDecimal(reader["preco"]),
                                    NomeCategoria = reader["nome_categoria"].ToString()
                                };
                                produtosCategorias.Add(produtoCategoria);

                                try
                                {
                                    nome_prod.Text = produtoCategoria.NomeProduto;
                                    AtualizarLabelsPrecoTotal();
                                }
                                catch
                                {
                                    nome_prod.Text = "Nome não encontrado!";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado!", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        dataGridViewCompras.DataSource = produtosCategorias;
                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao tentar conectar ao banco de dados! Detalhes: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarLabelsPrecoTotal()
        {
            decimal precoTotalCompra = CalcularPrecoTotalCompra();
            preco_total.Text = $"R$ {precoTotalCompra:F2}";
        }

        private decimal CalcularPrecoTotalCompra()
        {
            decimal precoTotal = 0;

            foreach (var produtoCategoria in produtosCategorias)
            {
                precoTotal += produtoCategoria.Preco * produtoCategoria.Quantidade;
            }

            return precoTotal;
        }

        public class ProdutoCategoria
        {
            public string CodigoProduto { get; set; }
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }
            public string NomeCategoria { get; set; }
        }

        public class ProdutoCodigo
        {
            public int CodigoProdutoList { get; set; }
        }

        public frm_caixa()
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

        private void frm_caixa_Load(object sender, EventArgs e)
        {

        }

        private void bnt_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var nomeFuncionario = InputDialog.ShowDialog("Informe o nome do funcionário", "Nome do Funcionário :");
                string connectionString = "Server=localhost;Database=db_pjsistema;User ID=root;Password=1234567;Charset=utf8";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlFuncionario = "SELECT id_funcionario FROM funcionario WHERE nome = @nomeFuncionario;";
                    using (MySqlCommand commandFuncionario = new MySqlCommand(sqlFuncionario, connection))
                    {
                        commandFuncionario.Parameters.AddWithValue("@nomeFuncionario", nomeFuncionario);
                        var idFuncionario = commandFuncionario.ExecuteScalar();

                        if (idFuncionario != null)
                        {
                            string sqlObterIdProduto = "SELECT codigo_produto FROM produto WHERE codigo_produto = @codigo;";
                            using (MySqlCommand commandObterIdProduto = new MySqlCommand(sqlObterIdProduto, connection))
                            {
                                var quantidadeMenos = Convert.ToInt32(textBoxQuantidade.Text);

                                // Limpar parâmetros antes de adicionar novos
                                commandObterIdProduto.Parameters.Clear();

                                var codigo = Convert.ToInt32(textBoxCodigo.Text);

                                commandObterIdProduto.Parameters.AddWithValue("@codigo", codigo);

                                using (MySqlDataReader readerIdProduto = commandObterIdProduto.ExecuteReader())
                                {
                                    if (readerIdProduto.Read())
                                    {
                                        int idProduto = Convert.ToInt32(readerIdProduto["codigo_produto"]);

                                        if (produtosCategorias.Any())
                                        {
                                            var precoTotal = produtosCategorias.Sum(produto => produto.Preco * produto.Quantidade);
                                            var quantidade = Convert.ToInt32(textBoxQuantidade.Text);

                                            string sqlVendaProduto = "INSERT INTO venda_produto (id_venda, id_produto) VALUES (@idVenda, @idProduto);";

                                            using (MySqlCommand commandVenda = new MySqlCommand(sqlVendaProduto, connection))
                                            {
                                                commandVenda.Parameters.AddWithValue("@valor", precoTotal * quantidade);
                                                commandVenda.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                                                readerIdProduto.Close();
                                                try
                                                {
                                                    // Obtenha o id do funcionário
                                                    string sqlObterIdFuncionario = "SELECT id_funcionario FROM funcionario WHERE nome = @nomeFuncionario;";
                                                    using (MySqlCommand commandObterIdFuncionario = new MySqlCommand(sqlObterIdFuncionario, connection))
                                                    {
                                                        commandObterIdFuncionario.Parameters.AddWithValue("@nomeFuncionario", nomeFuncionario);
                                                        idFuncionario = commandObterIdFuncionario.ExecuteScalar();

                                                        if (idFuncionario != null)
                                                        {
                                                            // Insira na tabela venda
                                                            string sqlInserirVenda = "INSERT INTO venda (data_venda, valor, frm_pagamento, id_funcionario) VALUES (NOW(), @valorTotal, @formaPagamento, @idFuncionario);";

                                                            using (MySqlCommand commandInserirVenda = new MySqlCommand(sqlInserirVenda, connection))
                                                            {
                                                                try
                                                                {
                                                                    int idFormPagamento = ObterIdFormaPagamento(connection, comboBoxFormaPag.SelectedItem.ToString());

                                                                    commandInserirVenda.Parameters.AddWithValue("@valorTotal", precoTotal);
                                                                    commandInserirVenda.Parameters.AddWithValue("@formaPagamento", idFormPagamento);
                                                                    commandInserirVenda.Parameters.AddWithValue("@idFuncionario", idFuncionario);

                                                                    commandInserirVenda.ExecuteNonQuery();

                                                                    int idVenda;
                                                                    string sqlUltimaVenda = "SELECT LAST_INSERT_ID();";

                                                                    using (MySqlCommand commandUltimaVenda = new MySqlCommand(sqlUltimaVenda, connection))
                                                                    {
                                                                        idVenda = Convert.ToInt32(commandUltimaVenda.ExecuteScalar());
                                                                    }

                                                                    using (MySqlCommand commandVendaProduto = new MySqlCommand(sqlVendaProduto, connection))
                                                                    {
                                                                        foreach (var produtoCategoria in produtosCategorias)
                                                                        {
                                                                            commandVendaProduto.Parameters.Clear();
                                                                            commandVendaProduto.Parameters.AddWithValue("@idVenda", idVenda);
                                                                            commandVendaProduto.Parameters.AddWithValue("@idProduto", produtoCategoria.CodigoProduto);

                                                                            try
                                                                            {
                                                                                commandVendaProduto.ExecuteNonQuery();
                                                                            }
                                                                            catch (MySqlException ex)
                                                                            {
                                                                                MessageBox.Show($"Erro ao inserir na tabela venda_produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                        }
                                                                        ReduzirProduto();
                                                                    }
                                                                    MessageBox.Show("Compra realizada com sucesso!");
                                                                    comboBoxFormaPag.SelectedItem = null;
                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show($"Erro ao inserir no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Funcionário não encontrado!", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                }
                                                catch (Exception error)
                                                {
                                                    MessageBox.Show($"Erro ao inserir na tabela venda: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }

                                            dataGridViewCompras.DataSource = null;
                                            dataGridViewCompras.Rows.Clear();
                                            produtosCategorias.Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Adicione produtos à venda antes de confirmar.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado!", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao tentar obter o ID do funcionário! Detalhes: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObterIdFormaPagamento(MySqlConnection connection, string formaPagamento)
        {
            string sqlObterIdFormaPagamento = "SELECT id_pagamento FROM forma_pagamento WHERE forma = @formaPagamento;";
            using (MySqlCommand command = new MySqlCommand(sqlObterIdFormaPagamento, connection))
            {
                command.Parameters.AddWithValue("@formaPagamento", formaPagamento);
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        /*
          
            private void ReduzirProduto()
        {
            string connectionString = "Server=localhost;Database=db_pjsistema;User ID=root;Password=1234567;Charset=utf8";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sqlObterIdProduto = "SELECT codigo_produto, quantidade FROM produto WHERE codigo_produto = @codigo;";
                using (MySqlCommand commandObterIdProduto = new MySqlCommand(sqlObterIdProduto, connection))
                {
                    commandObterIdProduto.Parameters.AddWithValue("@codigo", Convert.ToInt32(textBoxCodigo.Text));
                    using (MySqlDataReader readerIdProduto = commandObterIdProduto.ExecuteReader())
                    {
                        if (readerIdProduto.Read())
                        {
                            int idProduto = Convert.ToInt32(readerIdProduto["codigo_produto"]);
                            int quantidadeAtual = Convert.ToInt32(readerIdProduto["quantidade"]);
                            int quantidadeMenos = Convert.ToInt32(textBoxQuantidade.Text);

                            // Verificar se há quantidade suficiente para a venda
                            if (quantidadeAtual >= quantidadeMenos)
                            {
                                readerIdProduto.Close();
                                // Atualizar a quantidade na tabela produto
                                string sqlRetirarQuantidade = "UPDATE produto SET quantidade = @quantidadeAtual - @quantidadeMenos WHERE codigo_produto = @idProduto;";

                                using (MySqlCommand commandRetirarQuantidade = new MySqlCommand(sqlRetirarQuantidade, connection))
                                {
                                    commandRetirarQuantidade.Parameters.AddWithValue("@idProduto", idProduto);
                                    commandRetirarQuantidade.Parameters.AddWithValue("@quantidadeAtual", quantidadeAtual);
                                    commandRetirarQuantidade.Parameters.AddWithValue("@quantidadeMenos", quantidadeMenos);

                                    commandRetirarQuantidade.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantidade insuficiente em estoque.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
        }
        */

        private void ReduzirProduto()
        {
            try
            {
                string connectionString = "Server=localhost;Database=db_pjsistema;User ID=root;Password=1234567;Charset=utf8";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlObterIdProduto = "SELECT codigo_produto, quantidade FROM produto WHERE codigo_produto = @codigo;";
                    using (MySqlCommand commandObterIdProduto = new MySqlCommand(sqlObterIdProduto, connection))
                    {
                        commandObterIdProduto.Parameters.AddWithValue("@codigo", Convert.ToInt32(textBoxCodigo.Text));
                        using (MySqlDataReader readerIdProduto = commandObterIdProduto.ExecuteReader())
                        {
                            if (readerIdProduto.Read())
                            {
                                int idProduto = Convert.ToInt32(readerIdProduto["codigo_produto"]);
                                int quantidadeAtual = Convert.ToInt32(readerIdProduto["quantidade"]);
                                int quantidadeMenos = Convert.ToInt32(textBoxQuantidade.Text);

                                Console.WriteLine($"Quantidade Atual: {quantidadeAtual}, Quantidade Menos: {quantidadeMenos}");

                                // Verificar se há quantidade suficiente para a venda
                                if (quantidadeAtual >= quantidadeMenos)
                                {
                                    readerIdProduto.Close();
                                    Console.WriteLine("Quantidade suficiente para a venda. Atualizando quantidade...");

                                    // Atualizar a quantidade na tabela produto
                                    string sqlRetirarQuantidade = "UPDATE produto SET quantidade = @quantidadeAtual WHERE codigo_produto = @idProduto;";

                                    using (MySqlCommand commandRetirarQuantidade = new MySqlCommand(sqlRetirarQuantidade, connection))
                                    {
                                        commandRetirarQuantidade.Parameters.AddWithValue("@idProduto", idProduto);
                                        commandRetirarQuantidade.Parameters.AddWithValue("@quantidadeAtual", (quantidadeAtual - quantidadeMenos));

                                        commandRetirarQuantidade.ExecuteNonQuery();

                                        Console.WriteLine("Quantidade atualizada com sucesso!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Quantidade insuficiente em estoque.");
                                    MessageBox.Show("Quantidade insuficiente em estoque.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Produto não encontrado.");
                                MessageBox.Show("Produto não encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao reduzir produto: {ex.Message}");
                MessageBox.Show($"Erro ao reduzir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class InputDialog
        {
            public static string ShowDialog(string caption, string text)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
            }
        }
    }
}

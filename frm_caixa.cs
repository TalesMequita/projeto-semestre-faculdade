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
        private List<ProdutoCategoria> produtosCategorias = new List<ProdutoCategoria>();
        private List<ProdutoCodigo> produtosCodigos = new List<ProdutoCodigo>();

        private void bnt_adicionar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=db_pjsistema;User ID=root;Password=1234567;Charset=utf8";

            try {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"select p.codigo_produto, p.nome AS nome_produto, p.quantidade, p.preco, c.id_categoria, c.nome AS nome_categoria from produto_categoria pc JOIN produto p ON pc.codigo_produto = p.codigo_produto JOIN categoria c ON pc.id_categoria = c.id_categoria WHERE p.codigo_produto = @codigo;";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);

                        var codigo = Convert.ToInt32(textBoxCodigo.Text);
                        ProdutoCodigo produtoCodigo = new ProdutoCodigo { CodigoProdutoList = codigo };
                        produtosCodigos.Add(produtoCodigo);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) {

                                reader.Read();

                                ProdutoCategoria produtoCategoria = new ProdutoCategoria
                                {
                                    CodigoProduto = reader["codigo_produto"].ToString(),
                                    NomeProduto = reader["nome_produto"].ToString(),
                                    Quantidade = Convert.ToInt32(reader["quantidade"]),
                                    Preco = Convert.ToDecimal(reader["preco"]),
                                    IdCategoria = Convert.ToInt32(reader["id_categoria"]),
                                    NomeCategoria = reader["nome_categoria"].ToString()
                                };
                                produtosCategorias.Add(produtoCategoria);

                                try {
                                    nome_prod.Text = produtoCategoria.NomeProduto;
                                    preco_total.Text = "R$" + (produtoCategoria.Preco * produtoCategoria.Quantidade);
                                } catch {
                                    nome_prod.Text = "Nome não encontrado!";
                                }
                                dataGridViewCompras.DataSource = produtosCategorias;
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado!", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
            } catch (Exception error) 
            {
                MessageBox.Show($"Erro ao tentar conectar ao banco de dados! Detalhes: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public class ProdutoCategoria
        {
            public string CodigoProduto { get; set; }
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal Custo { get; set; }
            public decimal Preco { get; set; }
            public int IdCategoria { get; set; }
            public string NomeCategoria { get; set; }
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
            string connectionString = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlProduto = "UPDATE produto SET quantidade = quantidade - @quantidadeMenos WHERE codigo_produto = @codigo;";

                    foreach (var produtoCodigo in produtosCodigos)
                    {
                        using (MySqlCommand command = new MySqlCommand(sqlProduto, connection))
                        {
                            var quantidadeMenos = Convert.ToInt32(textBoxQuantidade.Text);

                            command.Parameters.AddWithValue("@codigo", produtoCodigo.CodigoProdutoList);
                            command.Parameters.AddWithValue("@quantidadeMenos", quantidadeMenos);
                            command.ExecuteNonQuery();
                        }
                    }

                    string sqlVenda = "INSERT INTO venda(data_venda, valor, id_funcionario, forma_pagamento) VALUES (GETDATE(), @valor, @id_funcionario, @forma_pagamento);";

                    using (MySqlCommand commandVenda = new MySqlCommand(sqlVenda, connection))
                    {
                        string sqlFuncionario = "SELECT id_funcionario FROM funcionario WHERE nome = @nome;";

                        try
                        {
                            string nomeUsuario = InputDialog.ShowDialog("Informe o nome do funcionário", "Nome do Funcionário:");

                            using (MySqlCommand commandFuncionario = new MySqlCommand(sqlFuncionario, connection))
                            {
                                commandFuncionario.Parameters.AddWithValue("@nome", nomeUsuario);
                                var idFuncionario = commandFuncionario.ExecuteScalar();

                                if (idFuncionario != null)
                                {
                                    if (produtosCategorias.Any())
                                    {

                                    var precoTotal = produtosCategorias.Sum(produto => produto.Preco * produto.Quantidade);
                                    var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                                    
                                    commandVenda.Parameters.AddWithValue("@valor", precoTotal * quantidade);
                                    commandVenda.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                                    commandVenda.Parameters.AddWithValue("@forma_pagamento", comboBoxFormaPag.Text);
                                    commandVenda.ExecuteNonQuery();

                                    } else
                                    {
                                        MessageBox.Show("Adicione produtos à venda antes de confirmar.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show($"Erro ao tentar obter o ID do funcionário! Detalhes: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show($"Erro SQL: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ProdutoCodigo
        {
            public int CodigoProdutoList { get; set; }
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

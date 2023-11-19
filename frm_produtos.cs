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
            // Pegando os valores inseridos:
            string nome = textBoxNome.Text;
            string categoria = textBoxCategoria.Text;
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
                Categoria = categoria,
                Marca = marca,
                Validade = validade
            };

            // Adicionando o objeto a uma lista
            listaProdutos.Add(produto);

            // Exibindo a lista no dataGridView
            dataGridViewProdutos.DataSource = listaProdutos;
        }

        // Botão de cancelamento, em que vai limpar as caixas e valores dos textBox e dataTimePicker
        private void bnt_cancelar(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxCategoria.Clear();
            textBoxMarca.Clear();
            textBoxValor.Clear();
            textBoxQuantidade.Clear();
            dateTimePickerValidade.Value = DateTime.Now; // Definindo para a data de hoje
        }

        // Botão de excluir que vai coletar a linha em que você clicar do dataGridView e apagar ela:
        private void bnt_excluir(object sender, EventArgs e) 
        {
            // Verificando se você clicou em uma linha
            if(dataGridViewProdutos.SelectedRows.Count > 0)
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
    }
}

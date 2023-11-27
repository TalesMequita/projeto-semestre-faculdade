using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Projeto_Faculdade
{
    public partial class frm_faturamento : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_faturamento()
        {
            InitializeComponent();
        }

        private void frm_faturamento_Load(object sender, EventArgs e)
        {

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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarGraficoColunas();
        }

        private void GerarGraficoColunas()
        {

            chart1.Series.Clear();
            chart1.Titles.Clear();

            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Vendas Mensais";
            chart1.Titles.Add(title);

            // Criar nova série para vendas
            chart1.Series.Add("vendas");
            chart1.Series["vendas"].LegendText = "Vendas";

            chart1.Series["vendas"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["vendas"].BorderWidth = 4;

            // Exemplo: Definindo intervalos de 1 mês no eixo X
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMM"; // Formatando para exibir apenas o nome do mês

            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT MONTH(data_venda) AS mes, SUM(valor) AS totalVendas FROM venda GROUP BY MONTH(data_venda) ORDER BY MONTH(data_venda)";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao))
                {
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mes = Convert.ToInt32(reader["mes"]);
                            string nomeMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                            int totalVendas = Convert.ToInt32(reader["totalVendas"]);

                            chart1.Series["vendas"].Points.AddXY(nomeMes, totalVendas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}

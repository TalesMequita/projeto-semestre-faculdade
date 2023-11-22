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

using MySql.Data.MySqlClient;

namespace Projeto_Faculdade
{
    public partial class frm_cadastro_usuario : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_cadastro_usuario()
        {
            InitializeComponent();
        }

        private void frm_cadastro_usuario_Load(object sender, EventArgs e)
        {
            PreencherComboBoxCargo();
        }
        private void PreencherComboBoxCargo() 
        {
            MySqlConnection Conexao = new MySqlConnection(data_source);

            string vqueryCargo = @"SELECT cargo FROM funcao ORDER BY int_cargo";

            MySqlCommand command = new MySqlCommand(vqueryCargo, Conexao);

            try
            {
                Conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string valor = reader["cargo"].ToString();
                    cb_cargo.Items.Add(valor);
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

        private void bnt_cadastrar(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Projeto_Faculdade
{
    public partial class frm_login : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234567;database=db_pjsistema";

        public frm_login()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        private void bnt_entrar(object sender, EventArgs e)
        {

            Conexao = new MySqlConnection(data_source);
            Conexao.Open();

            MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM contato_funcionario WHERE usuario = @usuario AND senha = @senha", Conexao);
            query.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            query.Parameters.AddWithValue("@senha", txtSenha.Text);


            int count = Convert.ToInt32(query.ExecuteScalar());

            if (count > 0)
            {
                var menu = new frm_menu();
                menu.Show();
                this.Visible = false;
                //MessageBox.Show("Usuário Existe");
            }
            else
            {
                MessageBox.Show("Usuário Inválido.");
                txtUsuario.Focus();
                txtSenha.Text = "";
            }

            Conexao.Close();

            /* try
            {
                if (txtUsuario.Text.Equals("adm") && txtSenha.Text.Equals("12345678")) 
                {
                    var menu = new frm_menu();
                    menu.Show();
                    this.Visible = false;

                } else
                {
                    MessageBox.Show("Usuario ou senha incorreto. ");
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Desculpe", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);    
            } */

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastro_usuario frm = new frm_cadastro_usuario();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }
    }
}

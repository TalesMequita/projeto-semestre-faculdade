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
            
        }

        private void bnt_cadastrar(object sender, EventArgs e)
        {
            
            try 
            { 
                // Conectando com MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd_cttFuncionario = new MySqlCommand();
                MySqlCommand cmd_Funcionario = new MySqlCommand();
                MySqlCommand cmd_Endereco = new MySqlCommand();
                
                cmd_Funcionario.Connection = Conexao;
                cmd_Endereco.Connection = Conexao;
                cmd_cttFuncionario.Connection = Conexao;

                // Table Endereço
                cmd_Endereco.CommandText = "INSERT INTO endereco_funcionario (endereco, CEP) " +
                                           "VALUES " + "(@endereco, @CEP)";

                cmd_Endereco.Parameters.AddWithValue("@endereco", txt_endereco.Text);
                cmd_Endereco.Parameters.AddWithValue("@CEP", txt_cep.Text);

                cmd_Endereco.Prepare();
                cmd_Endereco.ExecuteNonQuery();
                long idEndereco = cmd_Endereco.LastInsertedId;

                // Tabela contato_funcionario
                cmd_cttFuncionario.CommandText = "INSERT INTO contato_funcionario (funcao, usuario, senha, foto_patch) " +
                                  "VALUES " + "(@funcao, @usuario, @senha, @foto_patch)";

                cmd_cttFuncionario.Parameters.AddWithValue("@funcao", cb_cargo.Text);
                cmd_cttFuncionario.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                cmd_cttFuncionario.Parameters.AddWithValue("@senha", txt_senha.Text);
                cmd_cttFuncionario.Parameters.AddWithValue("@foto_patch", img_usuario.Text);

                cmd_cttFuncionario.Prepare();
                cmd_cttFuncionario.ExecuteNonQuery();
                long idContato = cmd_cttFuncionario.LastInsertedId;

                // Tabela Funcionario
                cmd_Funcionario.CommandText = "INSERT INTO funcionario (nome, email, telefone, CPF, id_contato, id_endereco) " +
                                              "VALUES " + "(@nome, @email, @telefone, @CPF, @id_contato, @id_endereco)";

                cmd_Funcionario.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd_Funcionario.Parameters.AddWithValue("@email", txt_email.Text);
                cmd_Funcionario.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                cmd_Funcionario.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                cmd_Funcionario.Parameters.AddWithValue("@id_contato", idContato);
                cmd_Funcionario.Parameters.AddWithValue("@id_endereco", idEndereco);

                cmd_Funcionario.Prepare();
                cmd_Funcionario.ExecuteNonQuery();

                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "erro", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Error);
            } finally
            {
                Conexao.Close();
            }

            frm_menu frm = new frm_menu();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();

            if (this.Visible)
            {
                this.Hide();
            }
            frm.ShowDialog();
            this.Close();
        }

        private void btn_buscarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivo de Imagem| * .jpg; *.jpeg; *.png";
            ofd.Title = "Selecione as Imagens";
            ofd.Multiselect = true;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                    pictureBox.Image = Image.FromFile(file);
                    img_usuario.Controls.Add(pictureBox);
                }
            }


        }

        private void btn_limparImg_Click(object sender, EventArgs e)
        {
            foreach (Control control in img_usuario.Controls)
            {
                if (control is PictureBox pictureBox) 
                {
                    img_usuario.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    break;
                }
            }
            
        }
    }
    
}

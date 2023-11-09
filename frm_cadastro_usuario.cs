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
    public partial class frm_cadastro_usuario : Form
    {
        public frm_cadastro_usuario()
        {
            InitializeComponent();
        }

        private void frm_cadastro_usuario_Load(object sender, EventArgs e)
        {

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

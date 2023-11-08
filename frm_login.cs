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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bnt_entrar(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            
            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();

            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}

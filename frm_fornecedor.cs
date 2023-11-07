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
    public partial class frm_fornecedor : Form
    {
        public frm_fornecedor()
        {
            InitializeComponent();
        }

        private void bnt_consultar(object sender, EventArgs e)
        {
            frm_consulta_fornecedores frm = new frm_consulta_fornecedores();

            if (this.Visible)
            {
                this.Hide();
            }

            frm.ShowDialog();
            this.Close();
        }
    }
}

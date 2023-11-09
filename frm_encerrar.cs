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
    public partial class frm_encerrar : Form
    {
        public frm_encerrar()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void bnt_Sim(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_Nao(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_alert_encerrar_Load(object sender, EventArgs e)
        {

        }
    }
}
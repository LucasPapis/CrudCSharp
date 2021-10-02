using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEvento.Telas;

namespace CrudEvento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventosG eg = new frmEventosG();
            eg.MdiParent = frmPrincipal.ActiveForm;
            eg.Show();
        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInstituicoes i = new frmInstituicoes();
            i.MdiParent = frmInstituicoes.ActiveForm;
            i.Show();
        }
    }
}

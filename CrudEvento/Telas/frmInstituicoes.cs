using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEvento.Classes;

namespace CrudEvento.Telas
{
    public partial class frmInstituicoes : Form
    {
        //Declarando lista para consulta de eventos
        private List<Instituicoes> listaInst = new List<Instituicoes>();

        //Usado para colocar a list<Eventos> antes de atribuir ao DataSource
        private BindingList<Instituicoes> listaInstDgv;
        public frmInstituicoes()
        {
            InitializeComponent();
        }
        private Boolean validaCampos()
        {
            if (txtNomeI.Text == string.Empty)
            {
                MessageBox.Show("O campo nome da instituição está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("O campo cidade está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUf.Text == string.Empty)
            {
                MessageBox.Show("O campo UF está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtIdI.Text == string.Empty)
            {
                MessageBox.Show("O campo ID está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void limpaCampos()
        {
            txtNomeI.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtIdI.Text = string.Empty;
        }
        private void buscaBanco()
        {
            listaInst = Instituicoes.consultarInst();
            listaInstDgv = new BindingList<Instituicoes>(listaInst);
            alimentaDgv(listaInstDgv);
        }
        private void alimentaDgv(BindingList<Instituicoes> listaInstDgv)
        {
            dgvInst.DataSource = listaInstDgv;
            dgvInst.Columns[0].HeaderText = "ID da instituição";
            dgvInst.Columns[1].HeaderText = "Nome da instituição";
            dgvInst.Columns[2].HeaderText = "Cidade";
            dgvInst.Columns[3].HeaderText = "UF";
        }

        private void preencheCampos(int index)
        {
            txtNomeI.Text = listaInst[index].Nm_inst.ToString();
            txtCidade.Text = listaInst[index].Ds_cidade.ToString();
            txtUf.Text = listaInst[index].Ds_uf.ToString();
            txtIdI.Text = listaInst[index].Id_inst.ToString();
        }

        private void frmInstituicoes_Load(object sender, EventArgs e)
        {
            buscaBanco();
        }

        private void btnCadastrarI_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                Instituicoes novaInst = new Instituicoes(Convert.ToInt32(txtIdI.Text), txtNomeI.Text, txtCidade.Text, txtUf.Text);
                novaInst.cadastraInst();
                limpaCampos();
                buscaBanco();
                txtNomeI.Focus();
            }
        }

        private void btnAlterarI_Click(object sender, EventArgs e)
        {
            int id_instSelecionada = listaInst[dgvInst.CurrentRow.Index].Id_inst;
            if (validaCampos())
            {
                listaInst[dgvInst.SelectedRows[0].Index].Id_inst = Convert.ToInt32(txtIdI.Text);
                listaInst[dgvInst.SelectedRows[0].Index].Nm_inst = txtNomeI.Text;
                listaInst[dgvInst.SelectedRows[0].Index].Ds_cidade = txtCidade.Text;
                listaInst[dgvInst.SelectedRows[0].Index].Ds_uf = txtUf.Text;
                listaInst[dgvInst.SelectedRows[0].Index].alteraInst(Convert.ToInt32(txtIdI.Text), id_instSelecionada);
                limpaCampos();
                buscaBanco();
                txtNomeI.Focus();
            }
        }

        private void btnExcluirI_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Deseja mesmo excluir a instituição?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                int id_eventoSelecionado = listaInst[dgvInst.CurrentRow.Index].Id_inst;
                listaInst[dgvInst.CurrentRow.Index].excluirInst(id_eventoSelecionado);
                limpaCampos();
                buscaBanco();
                txtNomeI.Focus();
            }
            else
            {

            }
        }

        private void dgvInst_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            preencheCampos(e.RowIndex);
        }
    }
}

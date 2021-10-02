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
    public partial class frmEventosG : Form
    {
        //Declarando lista para consulta de eventos
        private List<Eventos> listaEventos = new List<Eventos>();

        //Usado para colocar a list<Eventos> antes de atribuir ao DataSource
        private BindingList<Eventos> listaEventosDgv;

        public frmEventosG()
        {
            InitializeComponent();
        }
        private void frmEventosG_Load(object sender, EventArgs e)
        {
            buscaBanco();
        }
        private Boolean validaCampos()
        {
            if (txtNomeE.Text == string.Empty)
            {
                MessageBox.Show("O campo nome do evento está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskDtInicio.Text == string.Empty)
            {
                MessageBox.Show("O campo data de inicio está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskDtTermino.Text == string.Empty)
            {
                MessageBox.Show("O campo data de termino está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLocal.Text == string.Empty)
            {
                MessageBox.Show("O campo local está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("O campo valor está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("O campo ID está em branco!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void limpaCampos()
        {
            txtNomeE.Text = string.Empty;
            mskDtInicio.Text = string.Empty;
            mskDtTermino.Text = string.Empty;
            txtLocal.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtId.Text = string.Empty;
        }
        private void buscaBanco()
        {
            listaEventos = Eventos.consultarEventos();
            listaEventosDgv = new BindingList<Eventos>(listaEventos);
            alimentaDgv(listaEventosDgv);
        }
        private void alimentaDgv(BindingList<Eventos> listaEventosDgv) 
        {
            dgvEventos.DataSource = listaEventosDgv;
            dgvEventos.Columns[0].HeaderText = "ID do evento";
            dgvEventos.Columns[1].HeaderText = "Evento";
            dgvEventos.Columns[2].HeaderText = "Inicio";
            dgvEventos.Columns[3].HeaderText = "Termino";
            dgvEventos.Columns[4].HeaderText = "Local";
            dgvEventos.Columns[5].HeaderText = "Valor";
        }

        private void preencheCampos(int index)
        {
            txtNomeE.Text = listaEventos[index].Evento.ToString();
            mskDtInicio.Text = listaEventos[index].Data_inicio.ToString();
            mskDtTermino.Text = listaEventos[index].Data_termino.ToString();
            txtLocal.Text = listaEventos[index].Local.ToString();
            txtValor.Text = listaEventos[index].Valor.ToString();
            txtId.Text = listaEventos[index].Id_evento.ToString();
        }

        private void btnCadastrarE_Click(object sender, EventArgs e)
        {
            if (validaCampos()){
                Eventos novoEvento = new Eventos(Convert.ToInt32(txtId.Text), txtNomeE.Text, mskDtInicio.Text, mskDtTermino.Text, txtLocal.Text, Convert.ToInt32(txtValor.Text));
                novoEvento.cadastraEvento();
                txtNomeE.Focus();
                buscaBanco();
                limpaCampos();
            }   
        }

        private void dgvEventos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            preencheCampos(e.RowIndex);
        }

        private void btnAlterarE_Click(object sender, EventArgs e)
        {
            int id_eventoSelecionado = listaEventos[dgvEventos.CurrentRow.Index].Id_evento;
            if (validaCampos())
            {
                listaEventos[dgvEventos.SelectedRows[0].Index].Id_evento = Convert.ToInt32(txtId.Text);
                listaEventos[dgvEventos.SelectedRows[0].Index].Evento = txtNomeE.Text;
                listaEventos[dgvEventos.SelectedRows[0].Index].Data_inicio = mskDtInicio.Text;
                listaEventos[dgvEventos.SelectedRows[0].Index].Data_termino = mskDtTermino.Text;
                listaEventos[dgvEventos.SelectedRows[0].Index].Local = txtLocal.Text;
                listaEventos[dgvEventos.SelectedRows[0].Index].Valor = Convert.ToInt32(txtValor.Text);
                listaEventos[dgvEventos.SelectedRows[0].Index].alteraEvento(Convert.ToInt32(txtId.Text), id_eventoSelecionado);
                limpaCampos();
                buscaBanco();
                txtNomeE.Focus();
            }
        }

        private void btnExcluirE_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Deseja mesmo excluir esse evento?", string.Empty,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                int id_eventoSelecionado = listaEventos[dgvEventos.CurrentRow.Index].Id_evento;
                listaEventos[dgvEventos.CurrentRow.Index].excluirEvento(id_eventoSelecionado);
                limpaCampos();
                buscaBanco();
                txtNomeE.Focus();

            }
            else
            {

            }
        }
    }
}
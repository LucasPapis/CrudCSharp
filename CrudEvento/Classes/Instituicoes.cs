using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEvento.Classes
{
    class Instituicoes
    {
        #region Atributos
        private int id_instituicao;
        private string nm_instituicao;
        private string ds_cidade;
        private string ds_uf;
        #endregion

        #region Propriedades
        public int Id_inst
        {
            get { return id_instituicao; }
            set { id_instituicao = value; }
        }
        public string Nm_inst
        {
            get { return nm_instituicao; }
            set { nm_instituicao = value; }
        }
        public string Ds_cidade
        {
            get { return ds_cidade; }
            set { ds_cidade = value; }
        }
        public string Ds_uf
        {
            get { return ds_uf; }
            set { ds_uf = value; }
        }
        #endregion

        #region Construtores
        public Instituicoes()
        {

        }
        public Instituicoes(int id_intituicoes, string nm_instituicao, string ds_cidade, string ds_uf)
        {
            Id_inst = id_intituicoes;
            Nm_inst = nm_instituicao;
            Ds_cidade = ds_cidade;
            Ds_uf = ds_uf;
        }
        #endregion

        #region Métodos
        public void cadastraInst()
        {
            string query = string.Format("INSERT INTO Instituicoes (id_instituicao, nm_instituicao, ds_cidade, ds_uf) VALUES ('{0}','{1}','{2}','{3}')", Id_inst, Nm_inst, Ds_cidade, Ds_uf);
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Instituição cadastrada!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public static List<Instituicoes> consultarInst()
        {
            List<Instituicoes> listaInst = new List<Instituicoes>();
            string query = "SELECT * FROM Instituicoes";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaInst.Add(new Instituicoes(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString()));
                    }
                }
                return listaInst;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro:" + error.Message);
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void alteraInst(int id_inst, int id_instSelecionada)
        {
            string query = "";
            if (id_inst == id_instSelecionada)
            {
                query = string.Format("UPDATE Instituicoes SET nm_instituicao = '" + Nm_inst + "' ,ds_cidade = '" + Ds_cidade + "', ds_uf = '" + Ds_uf + "' WHERE id_instituicao = '" + id_instSelecionada + "'");
            }
            else
            {
                query = string.Format("UPDATE Instituicoes SET id_instituicao = '" + Id_inst + "', nm_instituicao = '" + Nm_inst + "' ,ds_cidade = '" + Ds_cidade + "', ds_uf = '" + Ds_uf + "' WHERE id_instituicao = '" + id_instSelecionada + "'");
            }
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Instituição Alterada!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void excluirInst(int id_instSelecionada)
        {
            string query = string.Format("DELETE FROM Instituicoes WHERE id_instituicao = '" + id_instSelecionada + "'");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Instituição Excluida!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        #endregion
    }
}

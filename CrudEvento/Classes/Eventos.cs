using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CrudEvento.Classes
{
    class Eventos
    {
        #region Atributos
        private int id_evento;
        private string evento;
        private string data_inicio;
        private string data_termino;
        private string local;
        private int valor;
        #endregion

        #region Propriedades
        public int Id_evento
        {
            get { return id_evento; }
            set { id_evento = value; }
        }
        public string Evento
        {
            get { return evento; }
            set { evento = value; }
        }
        public string Data_inicio
        {
            get { return data_inicio; }
            set { data_inicio = value; }
        }
        public string Data_termino
        {
            get { return data_termino; }
            set { data_termino = value; }
        }
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        #endregion

        #region Construtores
        public Eventos()
        {

        }
        
        //Esse construtor é utilizado para cadastro, consulta e alteração
        public Eventos(int id_evento,string evento, string data_inicio, string data_termino, string local, int valor)
        {
            Id_evento = id_evento;
            Evento = evento;
            Data_inicio = data_inicio;
            Data_termino = data_termino;
            Local = local;
            Valor = valor;
        }
        #endregion

        #region Métodos

        public void cadastraEvento()
        {
            string query = string.Format("INSERT INTO Eventos (id_evento, evento, data_inicio, data_termino, local, valor) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", Id_evento, Evento, Data_inicio, Data_termino, Local, Valor);
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Evento cadastrado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static List<Eventos> consultarEventos()
        {
            List<Eventos> listaEventos = new List<Eventos>();
            string query = "SELECT * FROM Eventos";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaEventos.Add(new Eventos(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            cn.dr[4].ToString(),
                            Convert.ToInt32(cn.dr[5])));
                    }
                }
                return listaEventos;
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

        public void alteraEvento(int id_evento, int id_eventoSelecionado)
        {
            string query = "";
            if (id_evento == id_eventoSelecionado )
            {
                query = string.Format("UPDATE Eventos SET evento = '"+Evento+"' , data_inicio = '"+Data_inicio+"' , data_termino = '"+Data_termino+"' , local = '"+Local+"', valor = '"+Valor+"' WHERE id_evento = '"+id_eventoSelecionado+"' ");
            }
            else
            {
                query = string.Format("UPDATE Eventos SET id_evento = '"+Id_evento+"' ,evento = '" + Evento + "' , data_inicio = '" + Data_inicio + "' , data_termino = '" + Data_termino + "' , local = '" + Local + "', valor = '" + Valor + "' WHERE id_evento = '" + id_eventoSelecionado + "' ");
            }
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Evento Alterado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void excluirEvento(int id_eventoSelecionado)
        {
            string query = string.Format("DELETE FROM Eventos WHERE id_evento = '"+id_eventoSelecionado+"'");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
                MessageBox.Show("Evento Excluido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
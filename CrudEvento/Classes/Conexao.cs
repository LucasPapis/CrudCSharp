using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CrudEvento.Classes
{
    class Conexao
    {
        public static string _conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbEvento.mdf;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(_conexao);
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds;

        public Conexao(string query)
        {
            cmd = new SqlCommand(query, conexao);
            da = new SqlDataAdapter(query, conexao);
            ds = new DataSet();
        }
        public void AbreConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }
        public void FecharConexao()
        {
            conexao.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projetoMeioAmbiente
{
    class conexaoBanco
    {
        SqlConnection con;
        public SqlConnection abrir_Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\gustavo.hrgomes\Documents\Banco.mdf;Integrated Security=True;Connect Timeout=30";

            con.Open();
            return con;
        }

        public void fechar_Conexao(SqlConnection con)
        {
            con.Close();
        }

    }
}

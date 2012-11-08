using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Controle_de_Midias
{
    class GerenciadorDeBanco
    {

        SqlConnection conexao = new SqlConnection();
        

        public bool AbrirConexao()
        {
            conexao.ConnectionString = "";

            try
            {
                conexao.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }
}

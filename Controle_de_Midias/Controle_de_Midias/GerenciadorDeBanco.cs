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

        public SqlConnection conexao = new SqlConnection();
        SqlCommand cmd;
        List<string> NomesAmigos = new List<string>();
        string cmdSQL;
        public bool AbrirConexao()
        {
            conexao.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ProjetoFinalPJS\Controle_de_Midias\Base de dados\ControleDeMidias.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            try
            {
                conexao.Open();

                //string codigo = "insert into Amigos(Nome,Telefone,Email,Observacao) values('Diego germano','diegjndkfvkvn','1236643832','nao temmmm')";
                //cmd = new SqlCommand(codigo,conexao);
                //cmd.ExecuteNonQuery();

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

        public List<string> ColetarNomes()
        {
           

            SqlDataReader Leitor;
            cmdSQL = "SELECT Nome FROM Amigos";

            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            while (Leitor.Read())
            {
                NomesAmigos.Add(Leitor["Nome"].ToString());
            }

            return NomesAmigos;

        }

        //public List<string> ProcuarAmigo()
        //{

        //    cmdSQL = "SELECTXÇ";

        //}
    }
}

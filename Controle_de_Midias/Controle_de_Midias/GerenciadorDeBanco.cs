using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    class GerenciadorDeBanco
    {

        SqlDataReader Leitor;
        public SqlConnection conexao = new SqlConnection();
        SqlCommand cmd;
        List<string> NomesAmigos = new List<string>();
        ListViewItem item = new ListViewItem();
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
           
            cmdSQL = "SELECT Nome FROM Amigos";

            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            while (Leitor.Read())
            {
                NomesAmigos.Add(Leitor["Nome"].ToString());
            }

            return NomesAmigos;

        }

        public int ProcuraIdentificador(Amigo selecionado)
        {
            int idAmigo;
            cmdSQL = "SELECT Id_Amigo FROM Amigos WHERE Nome = @nome AND Telefone = @telefone AND Email = @email and Observacao = @observacao ";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", selecionado.anterior[0]));
            cmd.Parameters.Add(new SqlParameter("@telefone", selecionado.anterior[1]));
            cmd.Parameters.Add(new SqlParameter("@email", selecionado.anterior[2]));
            cmd.Parameters.Add(new SqlParameter("@observacao", selecionado.anterior[3]));

            idAmigo = (int)cmd.ExecuteScalar();

            return idAmigo;
            
        }
        public void AlteraAmigo(Amigo altAmigo)
        {
            int id = ProcuraIdentificador(altAmigo);
            //Faz a atualização dados do amigo no banco de dados
            cmdSQL = "UPDATE Amigos SET Nome = @nome,Telefone = @telefone, Email = @email, Observacao = @observacao WHERE Nome = @id";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", altAmigo.nome));
            cmd.Parameters.Add(new SqlParameter("@telefone", altAmigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@email", altAmigo.email));
            cmd.Parameters.Add(new SqlParameter("@observacao", altAmigo.observacao));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.ExecuteNonQuery();
            
        }

        public void Remover(Amigo removeAmigo)
        {
            // Remove o amigo do banco de dados
            cmdSQL = "DELETE FROM Amigos WHERE Nome = @nome";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", removeAmigo.nome));

            cmd.ExecuteNonQuery();
        }

        public void PreencherLvMidias(ListView lv_Midias)
        {

            // Professor fez esta errado
            //if (!Leitor.IsClosed)
            //Leitor.Close();
           
            cmdSQL = "SELECT * FROM Midias";
            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            lv_Midias.Clear();
            lv_Midias.View = View.Details;
            lv_Midias.LabelEdit = true;
            lv_Midias.AllowColumnReorder = true;
            lv_Midias.CheckBoxes = true;
            lv_Midias.FullRowSelect = true;
            lv_Midias.GridLines = true;

            while (Leitor.Read())
            {
                
                item = new ListViewItem(Leitor["Nome_Album"].ToString());
                item.Group = lv_Midias.Groups[Leitor["Tipo_Midia"].ToString()];
                lv_Midias.Items.Add(item);
                item.SubItems.Add(Leitor["Nome_Interprete"].ToString());
                item.SubItems.Add(Leitor["Origem_Compra"].ToString());
                item.SubItems.Add(Leitor["Nome_Autor"].ToString());
                item.SubItems.Add(Leitor["Nome_Musica"].ToString());
                item.SubItems.Add(Leitor["Observacao"].ToString());
                item.SubItems.Add(Leitor["Nota"].ToString());
                item.SubItems.Add(Leitor["Data_Album"].ToString());
                item.SubItems.Add(Leitor["Data_Compra"].ToString());
            }
            Leitor.Close();    
        }

        public void PreecherLvAmigos(ListView lv_Amigos)
        {
            Leitor.Close();
            cmdSQL = "SELECT * FROM Amigos";
            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            lv_Amigos.FullRowSelect = true;
            lv_Amigos.GridLines = true;

            while (Leitor.Read())
            {
                item = new ListViewItem(Leitor["Nome"].ToString());
                
                lv_Amigos.Items.Add(item);
                item.SubItems.Add(Leitor["Telefone"].ToString());
                item.SubItems.Add(Leitor["Email"].ToString());
                item.SubItems.Add(Leitor["Observacao"].ToString());
            }
            Leitor.Close();
        }
    }
}

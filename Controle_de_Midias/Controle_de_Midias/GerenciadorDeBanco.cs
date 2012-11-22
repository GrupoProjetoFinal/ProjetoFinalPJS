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
        List<string> DadosAmigos = new List<string>();
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

        public void CadastroMidia(Midia midia)
        {
            cmdSQL = "Insert into midias (Interprete, autor, musica, album, data_album, data_Compra, compra, tipo, observacao) values (@Interprete, @autor, @musica, @album, @data_album, @data_Compra, @compra, @tipo, @observacao)";


            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Interprete", midia.interprete));
            cmd.Parameters.Add(new SqlParameter("@autor", midia.autor));
            cmd.Parameters.Add(new SqlParameter("@musica", midia.musica));
            cmd.Parameters.Add(new SqlParameter("@album", midia.album));
            cmd.Parameters.Add(new SqlParameter("@data_album", midia.dataAlbum));
            cmd.Parameters.Add(new SqlParameter("@data_compra", midia.dataCompra));
            cmd.Parameters.Add(new SqlParameter("@compra", midia.compra));
            cmd.Parameters.Add(new SqlParameter("@tipo", midia.observacao));

            cmd.ExecuteNonQuery();
            
            
            

        }

        public List<string> ColetarNomes()
        {
           
            cmdSQL = "SELECT Nome FROM Amigos";

            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            while (Leitor.Read())
            {
                DadosAmigos.Add(Leitor["Nome"].ToString());
            }
            Leitor.Close();
<<<<<<< .merge_file_a06452
            return NomesAmigos;
=======
            return DadosAmigos;
>>>>>>> .merge_file_a04264

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

        public List<string> ProcuarAmigo(string Nome)
        {
            DadosAmigos.Clear();

            cmdSQL = "SELECT * FROM Amigos WHERE Nome = @Nome";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
            Leitor = cmd.ExecuteReader();


            while (Leitor.Read())
            {
                DadosAmigos.Add(Leitor["Nome"].ToString());
                DadosAmigos.Add(Leitor["Telefone"].ToString());
                DadosAmigos.Add(Leitor["Email"].ToString());
                DadosAmigos.Add(Leitor["Observacao"].ToString());
                DadosAmigos.Add(Leitor["Id_Amigo"].ToString());
            }
            Leitor.Close();
            return DadosAmigos;
        }

        public void PreencherLvMidias(ListView lv_Midias)
        {
           
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

        public void EmprestarMidia(string idAmigo, List<string> DadosMidias)
        {

            int idMidia;

            // perguntar para o professor se a uma maneira melhor ....
            cmdSQL = "SELECT Id_Midia FROM Midias WHERE Nome_Album = '" + DadosMidias[0] + "' AND Nome_Interprete ='" + DadosMidias[1] + "' AND Origem_Compra = kk AND Nome_autor = kk AND Nome_Musica kk AND Observacao = kkk Nota = kk AND Dta = KK AND data = Kkk";
            cmd = new SqlCommand(cmdSQL, conexao);
            idMidia = (int)cmd.ExecuteScalar();

            cmdSQL = "INSERT INTO Emprestimos VALUES ('"+idMidia+"', '"+idAmigo+"', GETDATE(),0)";

            cmd = new SqlCommand(cmdSQL, conexao);

            //cmd.Parameters.Add(new SqlParameter("@Id_Midia",idmidia));
            //cmd.Parameters.Add(new SqlParameter("@Id_Amigo", idamigo));

            cmd.ExecuteNonQuery();
            
        }
    }
}

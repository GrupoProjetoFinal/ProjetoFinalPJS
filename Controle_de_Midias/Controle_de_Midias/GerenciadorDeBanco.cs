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
            cmd.Parameters.Add(new SqlParameter("@observacao", midia.observacao));

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

            return DadosAmigos;

        }

        public void InserirAmigo(Amigo novoAmigo)
        {
            // Faz a inserção do dados do novoAmigo para o banco de dados
            string sql = "INSERT INTO Amigos([Nome],[Telefone],[Email],[Observacao]) VALUES(@nome,@telefone,@email,@observacao)";
            cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", novoAmigo.nome));
            cmd.Parameters.Add(new SqlParameter("@telefone", novoAmigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@email", novoAmigo.email));
            cmd.Parameters.Add(new SqlParameter("@observacao", novoAmigo.observacao));

            cmd.ExecuteNonQuery();
        }

        public void AlteraAmigo(Amigo altAmigo)
        {
            //Faz a atualização dos dados do amigo no banco de dados
            cmdSQL = "UPDATE Amigos SET Nome = @nome,Telefone = @telefone, Email = @email, Observacao = @observacao WHERE Id_Amigo = @id";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", altAmigo.nome));
            cmd.Parameters.Add(new SqlParameter("@telefone", altAmigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@email", altAmigo.email));
            cmd.Parameters.Add(new SqlParameter("@observacao", altAmigo.observacao));
            cmd.Parameters.Add(new SqlParameter("@id", altAmigo.id));

            cmd.ExecuteNonQuery(); 
        }


        //  ATENÇÃOOOOOOOO            REMOVER ESTA COM BUG !!!!!!!!!!!!!!!!! 


        public void Remover(Amigo removeAmigo)
        {
            // Remove o amigo do banco de dados
            cmdSQL = "DELETE FROM Amigos WHERE Id_Amigo = @Id_Amigo";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@Id_Amigo", removeAmigo.id));

            cmd.ExecuteNonQuery();
        }

        public List<string> ProcurarAmigo(string Nome)
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

        public int ProcurarAmigo(Amigo amigo)
        {
            int id_amigo;

            cmdSQL = "SELECT id_Amigo FROM Amigos WHERE Nome = @Nome AND Email = @Email AND Telefone = @Telefone AND Observacao = @Observacao";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome",amigo.nome));
            cmd.Parameters.Add(new SqlParameter("@Telefone", amigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@Email",amigo.email));
            cmd.Parameters.Add(new SqlParameter("@Observacao",amigo.observacao));

            return id_amigo = (int)cmd.ExecuteScalar(); 
            
        }

        public void PreencherLvMidias(ListView lv_Midias, int id_Amigo)
        {
           if(id_Amigo == 0)
               cmdSQL = "SELECT * FROM Midias";
           else
               cmdSQL = "SELECT Midias.Nome_Album, Midias.Nome_Interprete, Midias.Origem_Compra,  Midias.Nome_Autor, Midias.Nome_Musica, Midias.Observacao, Midias.Nota, Midias.Data_Album, Midias.Data_Compra,Midias.Tipo_Midia FROM Emprestimos  INNER JOIN Midias ON Emprestimos.Id_Midia = Midias.Id_Midia WHERE Emprestimos.Id_Amigo = @Id_Amigo";

            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@Id_Amigo",id_Amigo));
            Leitor = cmd.ExecuteReader();

            while (Leitor.Read())
            {
                
                item = new ListViewItem(Leitor["Nome_Album"].ToString());
                item.Group = lv_Midias.Groups[Leitor["Tipo_Midia"].ToString()];
                lv_Midias.Items.Add(item);
                item.SubItems.Add(Leitor["Nome_Interprete"].ToString());
                item.SubItems.Add(Leitor["Nome_Autor"].ToString());
                item.SubItems.Add(Leitor["Nome_Musica"].ToString());
                item.SubItems.Add(Leitor["Nota"].ToString());
                item.SubItems.Add(Leitor["Data_Compra"].ToString());  
                item.SubItems.Add(Leitor["Data_Album"].ToString());              
                item.SubItems.Add(Leitor["Origem_Compra"].ToString());        
                item.SubItems.Add(Leitor["Observacao"].ToString());
            }
            Leitor.Close();    
        }


        public void VerificaDevedores(ListView lv_amigos)
        {

            cmdSQL = "SELECT Amigos.Nome, Amigos.Telefone, Amigos.Email, Amigos.Observacao FROM Emprestimos INNER JOIN Amigos ON Emprestimos.Id_Amigo = Amigos.Id_Amigo WHERE Emprestimos.Quantidade_Dias > 5 ORDER BY Amigos.Nome";

            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

            while(Leitor.Read())
                foreach(ListViewItem item in lv_amigos.Items)
                if(Leitor["Nome"].ToString()       == item.SubItems[0].Text &&
                   Leitor["Telefone"].ToString()   == item.SubItems[1].Text &&
                   Leitor["Email"].ToString()      == item.SubItems[2].Text &&
                   Leitor["Observacao"].ToString() == item.SubItems[3].Text)
                        item.ForeColor = System.Drawing.Color.Red;
            Leitor.Close();

        }
        public void PreecherLvAmigos(ListView lv_Amigos, string frm)
        {

            if (frm == "fm_Principal")
                cmdSQL = "SELECT * FROM Amigos ORDER BY Nome";

                                  //////                 akiiiiIIIIIIIIIIIIIIIIIII                                          ///////////////////////////
            // FALTA PENSAR UM JEITO DE QUE ESSE LISTVIEW SEJA PPREENCHIDO UM DETERMINADO NOME UMA VEZ
            // EX SE FULANO DE TAL ALUNO 10 MIDIAS ELE VAI APARECER 10X SENDO QUE O CORRETO É APARECER UMA VEZ
            else
                cmdSQL = "SELECT Amigos.Nome, Amigos.Email, Amigos.Telefone, Amigos.Observacao " + 
                         "FROM Emprestimos " + 
                         "INNER JOIN Amigos " +
                         "ON Emprestimos.Id_Amigo = Amigos.Id_Amigo ORDER BY Amigos.Nome";

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
            VerificaDevedores(lv_Amigos);
           
            
        }

        public void EmprestarOuDevolverMidia(int idAmigo, List<string> DadosMidias, string Verificador)
        {

            int idMidia;

            // Comando para obter o indificador da midia
            cmdSQL = "SELECT Id_Midia FROM Midias WHERE Nome_Album = @Nome_Album AND Nome_Interprete = @Nome_Interprete AND Origem_Compra =  @Origem_Compra AND Nome_autor = @Nome_autor AND Nome_Musica = @Nome_Musica AND Observacao = @Observacao AND Nota = @Nota AND Data_Compra = @Data_Compra AND Data_Album = @Data_Album";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome_Album", DadosMidias[0]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Interprete", DadosMidias[1]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Autor", DadosMidias[2]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Musica", DadosMidias[3]));
            cmd.Parameters.Add(new SqlParameter("@Nota", DadosMidias[4]));
            cmd.Parameters.Add(new SqlParameter("@Data_Compra", DadosMidias[5]));
            cmd.Parameters.Add(new SqlParameter("@Data_Album", DadosMidias[6]));
            cmd.Parameters.Add(new SqlParameter("@Origem_Compra", DadosMidias[7]));
            cmd.Parameters.Add(new SqlParameter("@Observacao", DadosMidias[8]));

            idMidia = (int)cmd.ExecuteScalar();

            // Armazana os indificadores de Amigos e Midias com a data atual da Maquina e a qtd de dias que sempre inicia com zero.

            if (Verificador == "fm_Emprestimo")
                cmdSQL = "INSERT INTO Emprestimos VALUES ( @id_Midia,@id_Amigo,  GETDATE(),0)";
            else
                cmdSQL = "DELETE FROM Emprestimos WHERE id_Amigo = @id_Amigo AND id_Midia = @id_Midia";
            cmd = new SqlCommand(cmdSQL, conexao);


            cmd.Parameters.Add(new SqlParameter("@id_Midia", idMidia));
            cmd.Parameters.Add(new SqlParameter("@id_Amigo", idAmigo));
            

            cmd.ExecuteNonQuery();
            
        }

        public void AcrecentaDias()
        {

            cmdSQL = "UPDATE Emprestimos SET Quantidade_Dias =  DATEDIFF ( DAY , Data_Emprestimo , GETDATE()) from Emprestimos ";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.ExecuteNonQuery();

        }

        public void MensagemDeErro()
        {
            MessageBox.Show("Não foi possivel se conectar com o banco de dados.", "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

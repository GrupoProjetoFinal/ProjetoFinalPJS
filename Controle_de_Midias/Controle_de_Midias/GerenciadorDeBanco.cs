﻿using System;
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

        #region Controle de acesso ao Banco de dados
        //---------------------------------------------------------------------------------------------

        public bool AbrirConexao()
        {
            conexao.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ProjetoFinalPJS\Controle_de_Midias\Base de dados\ControleDeMidias.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

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

        #endregion

        #region Modificadores das Midias
        //----------------------------------------------------------------------------------------------

        public void CadastroMidia(Midia midia)
        {
            cmdSQL = "Insert into midias (Nome_Interprete, Nome_Autor, Nome_Musica, Nome_Album, Data_album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota) values (@Nome_Interprete, @Nome_Autor, @Nome_Musica, @Nome_Album, @Data_album, @Data_Compra, @Origem_Compra, @Tipo_Midia, @Observacao, @Nota)";


            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome_Interprete", midia.interprete));
            cmd.Parameters.Add(new SqlParameter("@Nome_Autor", midia.autor));
            cmd.Parameters.Add(new SqlParameter("@Nome_Musica", midia.musica));
            cmd.Parameters.Add(new SqlParameter("@Nome_Album", midia.album));
            cmd.Parameters.Add(new SqlParameter("@Data_Album", midia.dataAlbum));
            cmd.Parameters.Add(new SqlParameter("@Data_Compra", midia.dataCompra));
            cmd.Parameters.Add(new SqlParameter("@Origem_Compra", midia.compra));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Midia", midia.tipo));
            cmd.Parameters.Add(new SqlParameter("@observacao", midia.observacao));
            cmd.Parameters.Add(new SqlParameter("@Nota", midia.nota));

            cmd.ExecuteNonQuery();
        }

        public void AlterarMidia(Midia emAlteracao)
        {
            cmdSQL = "UPDATE Midias SET Nome_Album = @Nome_Album, Nome_Interprete = @Nome_Interprete, Origem_Compra =  @Origem_Compra, Nome_autor = @Nome_autor, Nome_Musica = @Nome_Musica, Observacao = @Observacao, Nota = @Nota, Data_Compra = @Data_Compra, Data_Album = @Data_Album WHERE Id_Midia = @idMidia";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome_Album", emAlteracao.album));
            cmd.Parameters.Add(new SqlParameter("@Nome_Interprete", emAlteracao.interprete));
            cmd.Parameters.Add(new SqlParameter("@Nome_Autor", emAlteracao.autor));
            cmd.Parameters.Add(new SqlParameter("@Nome_Musica", emAlteracao.musica));
            cmd.Parameters.Add(new SqlParameter("@Nota", emAlteracao.nota));
            cmd.Parameters.Add(new SqlParameter("@Data_Compra", emAlteracao.dataCompra));
            cmd.Parameters.Add(new SqlParameter("@Data_Album", emAlteracao.dataAlbum));
            cmd.Parameters.Add(new SqlParameter("@Origem_Compra", emAlteracao.compra));
            cmd.Parameters.Add(new SqlParameter("@Observacao", emAlteracao.observacao));
            cmd.Parameters.Add(new SqlParameter("@idMidia", emAlteracao.id));

            cmd.ExecuteNonQuery();
        }

        public void ExcluirMidia(Midia Apagar)
        {
            // Remove o amigo do banco de dados
            cmdSQL = "DELETE FROM Midias WHERE Id_Midia = @Id_midia";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@Id_midia", Apagar.id));

            cmd.ExecuteNonQuery();
        }

        #endregion

        #region Modificadores dos Amigos
        //----------------------------------------------------------------------------------------------

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

        #endregion

        #region Métodos de preenchimento
        //----------------------------------------------------------------------------------------------



        // EM TESTE O LISTVIEW DO EMPRESTIMO CHAMA ESSE MÉTODO PARA PREENCHE-LO SOMENTE COM AS MIDIAS QUE ESTÃO DISPONIVEL OU SEJA QUE NAO ESTEJAM EMPRESTADAS
        // DEVE SER ARRUMAR O SELECT PARA RETORNAR ESSA CONSULTA PODENDO ASSIM O USUARIO EMPRESTAR SOMENTE AS DISPONIVEIS.................
        public void PreencherLvMidias(ListView lv_Midias)
        {
            //cmdSQL = "SELECT Midias.Nome_Album, Midias.Nome_Interprete, Midias.Origem_Compra,  Midias.Nome_Autor, Midias.Nome_Musica, Midias.Observacao, Midias.Nota, Midias.Data_Album, Midias.Data_Compra,Midias.Tipo_Midia FROM Emprestimos  INNER JOIN Midias ON Emprestimos.Id_Midia = Midias.Id_Midia WHERE Emprestimos.Id_Midia <> Midias.Id_Midia";
            //cmdSQL = "SELECT Midias.Nome_Album, Midias.Nome_Interprete, Midias.Origem_Compra,  Midias.Nome_Autor, Midias.Nome_Musica, Midias.Observacao, Midias.Nota, Midias.Data_Album, Midias.Data_Compra,Midias.Tipo_Midia FROM Emprestimos  INNER JOIN Midias ON Emprestimos.Id_Midia = Midias.Id_Midia";
            cmdSQL = "SELECT * FROM Midias"; 
            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();
            PreencherListView(lv_Midias, Leitor);
        }
        public void PreencherLvMidias(ListView lv_Midias, int id_Amigo)
        {
            if (id_Amigo == 0)
                cmdSQL = "SELECT * FROM Midias";
            else
                cmdSQL = "SELECT Midias.Nome_Album, Midias.Nome_Interprete, Midias.Origem_Compra,  Midias.Nome_Autor, Midias.Nome_Musica, Midias.Observacao, Midias.Nota, Midias.Data_Album, Midias.Data_Compra,Midias.Tipo_Midia FROM Emprestimos  INNER JOIN Midias ON Emprestimos.Id_Midia = Midias.Id_Midia WHERE Emprestimos.Id_Amigo = @Id_Amigo";

            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@Id_Amigo", id_Amigo));
            Leitor = cmd.ExecuteReader();
            PreencherListView(lv_Midias, Leitor);

        }

        public void PreecherLvAmigos(ListView lv_Amigos, string frm)
        {

            if (frm == "fm_Principal")
                cmdSQL = "SELECT * FROM Amigos ORDER BY Nome";
            else
                cmdSQL = "SELECT DISTINCT Amigos.Nome, Amigos.Email, Amigos.Telefone, Amigos.Observacao " +
                         "FROM Emprestimos " +
                         "INNER JOIN Amigos " +
                         "ON Emprestimos.Id_Amigo = Amigos.Id_Amigo ORDER BY Amigos.Nome";

            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();


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


        private void PreencherListView(ListView lv, SqlDataReader Leitor)
        {
            while (Leitor.Read())
            {

                item = new ListViewItem(Leitor["Nome_Album"].ToString());
                item.Group = lv.Groups[int.Parse(Leitor["Tipo_Midia"].ToString())];
                lv.Items.Add(item);
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

        #endregion

        #region Captura dos identificadores das tabelas
        //----------------------------------------------------------------------------------------------

        public int PegarIdentificadorAmigo(Amigo amigo)
        {
            // Localiza o amigo retornando o id para o método que o chamou. 
            int id_amigo;

            cmdSQL = "SELECT id_Amigo FROM Amigos WHERE Nome = @Nome AND Email = @Email AND Telefone = @Telefone AND Observacao = @Observacao";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome", amigo.nome));
            cmd.Parameters.Add(new SqlParameter("@Telefone", amigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@Email", amigo.email));
            cmd.Parameters.Add(new SqlParameter("@Observacao", amigo.observacao));

            return id_amigo = (int)cmd.ExecuteScalar();

        }

        public int PegaIdentificadorMidias(Midia midia)
        {
            int id_midia;

            cmdSQL = "SELECT Id_Midia FROM Midias WHERE Nome_Album = @Nome_Album AND Nome_Interprete = @Nome_Interprete AND Origem_Compra =  @Origem_Compra AND Nome_autor = @Nome_autor AND Nome_Musica = @Nome_Musica AND Observacao = @Observacao AND Nota = @Nota AND Data_Compra = @Data_Compra AND Data_Album = @Data_Album";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome_Album", midia.album));
            cmd.Parameters.Add(new SqlParameter("@Nome_Interprete", midia.interprete));
            cmd.Parameters.Add(new SqlParameter("@Origem_Compra", midia.compra));
            cmd.Parameters.Add(new SqlParameter("@Nome_Autor", midia.autor));
            cmd.Parameters.Add(new SqlParameter("@Nome_Musica", midia.musica));
            cmd.Parameters.Add(new SqlParameter("@Observacao", midia.observacao));
            cmd.Parameters.Add(new SqlParameter("@Nota", midia.nota));
            cmd.Parameters.Add(new SqlParameter("@Data_Compra", midia.dataCompra));
            cmd.Parameters.Add(new SqlParameter("@Data_Album", midia.dataAlbum));


            return id_midia = (int)cmd.ExecuteScalar();
        }

        #endregion

        #region Métodos de Procura
        //----------------------------------------------------------------------------------------------

        public List<string> ProcurarAmigo(string Nome, string tel,string email,string obs)
        {
            DadosAmigos.Clear();

            cmdSQL = "SELECT * FROM Amigos WHERE Nome = @Nome AND Telefone = @Telefone AND Email = @Email AND Observacao = @Observacao ";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
            cmd.Parameters.Add(new SqlParameter("@Telefone", tel));
            cmd.Parameters.Add(new SqlParameter("@Email", email));
            cmd.Parameters.Add(new SqlParameter("@Observacao", obs));
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

        public void ProcurarMidia(ListView lv_Midias, Midia midia, DateTime dataCompraFIM, DateTime dataAlbumFIM,string qualquerData)
        {
            //cmdSQL = "SELECT * FROM Midias " +
            //         "WHERE (@interprete = 'null'  OR Nome_Interprete  LIKE('%@interprete%'))        AND" +
            //         "      (@musica     = 'null'  OR Nome_Musica      LIKE('%@musica%'))            AND" +
            //         "      (@album      = 'null'  OR Nome_Album       LIKE('%@album%'))             AND" +
            //         "      (@autor      = 'null'  OR Nome_Autor       LIKE('%@autor%'))             AND" +
            //         "      (@compra     = 'null'  OR Origem_Compra    LIKE('%@compra%'))            AND" +
            //         "      (@observacao = 'null'  OR Observacao       LIKE('%@observacao%'))        AND" +
            //         "      (@nota       = '-' OR @nota = Nota)                                  AND" +
            //         "      (@tipo       = '11' OR @tipo = Tipo_Midia)                            AND" +
            //         "      (Data_Album  >= @dataAlbumInicio AND Data_Album <= @dataAlbumFIM)    AND" +
            //         "      (Data_Compra >= @dataCompraInicio AND Data_Album <= @dataCompraFIM)     ";


            cmdSQL = "SELECT * FROM Midias  " +
      "WHERE ('" + midia.interprete + "'       = ''  OR Nome_Interprete  LIKE('%" + midia.interprete + "%'))        AND" +
      "('" + midia.musica + "'       = ''  OR Nome_Musica      LIKE('%" + midia.musica + "%'))            AND" +
      "('" + midia.album + "'       = ''  OR Nome_Album       LIKE('%" + midia.album + "%'))             AND" +
      "('" + midia.autor + "'      = ''  OR Nome_Autor        LIKE('%" + midia.autor + "%'))             AND" +
      "('" + midia.compra + "'   = ''  OR Origem_Compra    LIKE('%" + midia.compra + "%'))            AND" +
      "('" + midia.observacao + "'       = ''  OR Observacao       LIKE('%" + midia.observacao + "%'))        AND" +
      "(@nota       = '0 - 10' OR @nota = Nota)                                  AND" +
      "(@tipo       = '-1' OR @tipo = Tipo_Midia)                            AND" +
      "(Data_Album  >= @dataAlbumInicio AND Data_Album <= @dataAlbumFIM)    AND" +
      "(Data_Compra >= @dataCompraInicio AND Data_Album <= @dataCompraFIM)";     
      

            cmd = new SqlCommand(cmdSQL, conexao);

            //cmd.Parameters.Add(new SqlParameter("@interprete", midia.interprete));
            //cmd.Parameters.Add(new SqlParameter("@musica", midia.musica));
            //cmd.Parameters.Add(new SqlParameter("@album", midia.album));
            //cmd.Parameters.Add(new SqlParameter("@autor", midia.autor));
            //cmd.Parameters.Add(new SqlParameter("@compra", midia.compra));
            cmd.Parameters.Add(new SqlParameter("@tipo", midia.tipo));
            cmd.Parameters.Add(new SqlParameter("@nota", midia.nota));
            //cmd.Parameters.Add(new SqlParameter("@observacao", midia.observacao));
            cmd.Parameters.Add(new SqlParameter("@dataAlbumInicio", midia.dataAlbum));
            cmd.Parameters.Add(new SqlParameter("@dataAlbumFIM", dataAlbumFIM));
            cmd.Parameters.Add(new SqlParameter("@dataCompraInicio", midia.dataCompra));
            cmd.Parameters.Add(new SqlParameter("@dataCompraFIM", dataCompraFIM));
            Leitor = cmd.ExecuteReader();

            lv_Midias.Items.Clear();
            PreencherListView(lv_Midias, Leitor);
        }

        #endregion
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
     
        public void EmprestarOuDevolverMidia(int idAmigo, List<string> DadosMidias, string Verificador)
        {



            int idMidia;

            // Comando para obter o indificador da midia
            cmdSQL = "SELECT Id_Midia                              "+ 
                    " FROM   Midias                                "+
                     "WHERE Nome_Album      = @Nome_Album        AND "+
                           "Nome_Interprete = @Nome_Interprete   AND "+
                           "Origem_Compra   = @Origem_Compra     AND "+
                           "Nome_autor      = @Nome_autor        AND "+
                           "Nome_Musica     = @Nome_Musica       AND "+
                           "Observacao      = @Observacao        AND "+
                           "Nota            = @Nota              ";

            cmd = new SqlCommand(cmdSQL, conexao);

            cmd.Parameters.Add(new SqlParameter("@Nome_Album",      DadosMidias[0]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Interprete", DadosMidias[1]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Autor",      DadosMidias[2]));
            cmd.Parameters.Add(new SqlParameter("@Nome_Musica",     DadosMidias[3]));
            cmd.Parameters.Add(new SqlParameter("@Nota",            DadosMidias[4]));
            cmd.Parameters.Add(new SqlParameter("@Origem_Compra",   DadosMidias[7]));
            cmd.Parameters.Add(new SqlParameter("@Observacao",      DadosMidias[8]));
            
            idMidia = (int)cmd.ExecuteScalar();

            // Armazana os indificadores de Amigos e Midias com a data atual da Maquina e a qtd de dias que sempre inicia com zero.
            if (Verificador == "fm_Emprestimo")
            {
                cmdSQL = "INSERT INTO Emprestimos VALUES ( @id_Midia,@id_Amigo,  GETDATE(),0)";
            }
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

        public int ContadarRegistros()
        {
            cmdSQL = "SELECT COUNT(*) FROM Emprestimos";
            cmd = new SqlCommand(cmdSQL,conexao);
            return (int)cmd.ExecuteScalar();
        }


        public bool VerificaLogin()
        {
            int abilitarLogin;
            cmdSQL = "SELECT AbilitarLogin FROM Usuario";
            cmd = new SqlCommand(cmdSQL, conexao);

            abilitarLogin = (int)cmd.ExecuteScalar();

            if (abilitarLogin == 1)
                return false;
            return true;
        }


        public void Configurar(int abilitarLogin)
        {
            
            cmdSQL= "UPDATE Usuario SET AbilitarLogin = @AbilitarLogin";

            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@AbilitarLogin",abilitarLogin));
            cmd.ExecuteNonQuery();
        }

    }
}

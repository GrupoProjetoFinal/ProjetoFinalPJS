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
                NomesAmigos.Add(Leitor["Nome"].ToString());
            }
            Leitor.Close();
            return NomesAmigos;

        }

        public void AlteraAmigo(Amigo altAmigo)
        {
            cmdSQL = "UPDATE Amigos SET Nome = @nome,TTelefone = @telefone, Email = @email, Observacao = @observacao" +
                     "WHERE ([Nome] = @nome)";
            cmd = new SqlCommand(cmdSQL, conexao);
            cmd.Parameters.Add(new SqlParameter("@nome", altAmigo.nome));
            cmd.Parameters.Add(new SqlParameter("@telefone", altAmigo.telefone));
            cmd.Parameters.Add(new SqlParameter("@email", altAmigo.email));
            cmd.Parameters.Add(new SqlParameter("@observacao", altAmigo.observacao));

            cmd.ExecuteNonQuery();
        }

        //public List<string> ProcuarAmigo()
        //{

        //    cmdSQL = "SELECTXÇ";

        //}

        public void PreencherLvMidias(ListView lv_Midias)
        {

            
            cmdSQL = "SELECT * FROM Midias";
            cmd = new SqlCommand(cmdSQL, conexao);
            Leitor = cmd.ExecuteReader();

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

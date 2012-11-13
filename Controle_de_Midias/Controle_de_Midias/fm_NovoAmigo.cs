using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Controle_de_Midias
{
    public partial class fm_NovoAmigo : Form
    {
        public fm_NovoAmigo()
        {
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            // O conteúdo dos textBox são parrados para o objeto Amigo.
            Amigo novoAmigo = new Amigo();
            novoAmigo.nome = tb_Nome.Text;
            novoAmigo.telefone = tb_Telefone.Text;
            novoAmigo.email = tb_Email.Text;
            novoAmigo.observacao = rtb_Observacao.Text;

            // Faz a inserção do dados do novoAmigo para o banco de dados
            string sql = "INSERT INTO Amigos([Nome],[Telefone],[Email],[Observacao])" +
                         "VALUES(@nome,@telefone,@email,@observacao)"; 
            SqlCommand comando = null;
            GerenciadorDeBanco inserirDadosAmigo = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (inserirDadosAmigo.AbrirConexao())
            {
                comando = new SqlCommand(sql, inserirDadosAmigo.conexao);
                comando.Parameters.Add(new SqlParameter("@nome", novoAmigo.nome));
                comando.Parameters.Add(new SqlParameter("@telefone", novoAmigo.telefone));
                comando.Parameters.Add(new SqlParameter("@email", novoAmigo.email));
                comando.Parameters.Add(new SqlParameter("@observacao", novoAmigo.observacao));

                comando.ExecuteNonQuery();

                //Fecha a coneção
                inserirDadosAmigo.FecharConexao();

                //Limpa os textBox
                tb_Nome.Clear();
                tb_Telefone.Clear();
                tb_Email.Clear();
                rtb_Observacao.Clear();
            }
            else
            {
                MessageBox.Show("Não foi possivel se conectar com o banco de dados.","Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


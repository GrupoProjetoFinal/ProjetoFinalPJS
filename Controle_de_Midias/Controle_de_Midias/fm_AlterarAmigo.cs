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
    public partial class fm_AlterarAmigo : Form
    {
        public fm_AlterarAmigo()
        {
            InitializeComponent();
        }

        public void Preencher(Amigo rescrever)
        {
            tb_NomeAlt.Text = rescrever.nome;
            tb_TelefoneAlt.Text = rescrever.telefone;
            tb_EmailAlt.Text = rescrever.email;
            rtb_ObservacaoAlt.Text = rescrever.observacao;
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            GerenciadorDeBanco GBD = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (GBD.AbrirConexao())
            {

                GBD.AlteraAmigo(enviaParaObjeto());
                //Fecha a coneção
                GBD.FecharConexao();

                //Limpa os textBox
                tb_NomeAlt.Clear();
                tb_TelefoneAlt.Clear();
                tb_EmailAlt.Clear();
                rtb_ObservacaoAlt.Clear();

            }
            else
            {
                MessageBox.Show("Não foi possivel se conectar com o banco de dados.", "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            GerenciadorDeBanco GBD = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (GBD.AbrirConexao())
            {

                GBD.Remover(enviaParaObjeto());
                //Fecha a coneção
                GBD.FecharConexao();

                //Limpa os textBox
                tb_NomeAlt.Clear();
                tb_TelefoneAlt.Clear();
                tb_EmailAlt.Clear();
                rtb_ObservacaoAlt.Clear();

            }
            else
            {
                MessageBox.Show("Não foi possivel se conectar com o banco de dados.", "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private Amigo enviaParaObjeto()
        {
            // O conteúdo dos textBox são parrados para o objeto Amigo.
            Amigo AlteraAmigo = new Amigo();


            AlteraAmigo.nome = tb_NomeAlt.Text;
            AlteraAmigo.telefone = tb_TelefoneAlt.Text;
            AlteraAmigo.email = tb_EmailAlt.Text;
            AlteraAmigo.observacao = rtb_ObservacaoAlt.Text;

            return AlteraAmigo;
        }
    }
}

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
        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            // O conteúdo dos textBox são parrados para o objeto Amigo.
            Amigo novoAmigo = new Amigo();
            novoAmigo.nome = tb_NomeAlt.Text;
            novoAmigo.telefone = tb_TelefoneAlt.Text;
            novoAmigo.email = tb_EmailAlt.Text;
            novoAmigo.observacao = rtb_ObservacaoAlt.Text;

            GerenciadorDeBanco GBD = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (GBD.AbrirConexao())
            {

                GBD.AlteraAmigo(novoAmigo);
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
        }
    }
}

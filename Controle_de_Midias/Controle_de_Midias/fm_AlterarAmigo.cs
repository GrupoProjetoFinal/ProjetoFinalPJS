using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    public partial class fm_AlterarAmigo : Form
    {
        public fm_AlterarAmigo()
        {
            InitializeComponent();
        }

        private GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private int idAmigo;

        //Preenche os TextBox com o item selecionado no ListView do fm_Principal.
        public void Preencher(Amigo rescrever)
        {
            tb_NomeAlt.Text = rescrever.nome;
            tb_TelefoneAlt.Text = rescrever.telefone;
            tb_EmailAlt.Text = rescrever.email;
            rtb_ObservacaoAlt.Text = rescrever.observacao;

            GBD.AbrirConexao();
            idAmigo = GBD.ProcurarAmigo(rescrever); 
            GBD.FecharConexao();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            //verifica se a conecção foi aberta, se sim executa o comando SQL no GErenciadorDeBAnco.
            if (GBD.AbrirConexao())
            {
                GBD.AlteraAmigo(enviaParaObjeto());
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
            this.Close();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            //Verifica se a conecção foi aberta, se sim executa o comando SLQ no GerenciadorDeBanco.
            if (GBD.AbrirConexao())
            {
                GBD.Remover(enviaParaObjeto());
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
            this.Close();
        }

        private Amigo enviaParaObjeto()
        {
            // O conteúdo dos TextBox são passados para o objeto Amigo.
            Amigo AlteraAmigo = new Amigo();
            AlteraAmigo.nome = tb_NomeAlt.Text;
            AlteraAmigo.telefone = tb_TelefoneAlt.Text;
            AlteraAmigo.email = tb_EmailAlt.Text;
            AlteraAmigo.observacao = rtb_ObservacaoAlt.Text;
            AlteraAmigo.id = idAmigo;

            return AlteraAmigo;
        }
    }
}

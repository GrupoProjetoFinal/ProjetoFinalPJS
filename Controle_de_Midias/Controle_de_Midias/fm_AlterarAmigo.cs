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


        public bool alterar = false;
        public bool excluir = false;
        private GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        public Amigo NovoAmigo = new Amigo();
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
                alterar = true;
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
                excluir = true;
            }
            else
                GBD.MensagemDeErro();

            this.Close();
           
            
        }

        private Amigo enviaParaObjeto()
        {
            NovoAmigo.nome = tb_NomeAlt.Text;
            NovoAmigo.telefone = tb_TelefoneAlt.Text;
            NovoAmigo.email = tb_EmailAlt.Text;
            NovoAmigo.observacao = rtb_ObservacaoAlt.Text;
            NovoAmigo.id = idAmigo;

            // O conteúdo dos TextBox são passados para o objeto Amigo.
            
            return NovoAmigo;
        }

        private void fm_AlterarAmigo_Load(object sender, EventArgs e)
        {

        }
    }
}

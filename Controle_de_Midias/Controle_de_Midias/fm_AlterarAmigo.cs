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

            if (GBD.AbrirConexao())
            {
                idAmigo = GBD.PegarIdentificadorAmigo(rescrever);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
        }

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            //verifica se a conecção foi aberta, se sim executa o comando SQL no GErenciadorDeBAnco.
            if (tb_NomeAlt.Text != string.Empty)
            {
                if (GBD.AbrirConexao())
                {
                    GBD.AlteraAmigo(InserirDados());
                    GBD.FecharConexao();
                    alterar = true;
                }
                else
                    GBD.MensagemDeErro();

                this.Close();
         
            }
            else
            {
                lb_InfoUsuario.Visible = true;
                erroP.SetError(lb_InfoUsuario, "O campo nome é obrigatório");
            }

        }

        private Amigo InserirDados()
        {
            NovoAmigo.nome = tb_NomeAlt.Text;
            NovoAmigo.telefone = tb_TelefoneAlt.Text;
            NovoAmigo.email = tb_EmailAlt.Text;
            NovoAmigo.observacao = rtb_ObservacaoAlt.Text;
            NovoAmigo.id = idAmigo;

            // O conteúdo dos TextBox são passados para o objeto Amigo.
            
            return NovoAmigo;
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            //Verifica se a conecção foi aberta, se sim executa o comando SLQ no GerenciadorDeBanco.
            if (GBD.AbrirConexao())
            {
                GBD.Remover(InserirDados());
                GBD.FecharConexao();
                excluir = true;
            }
            else
                GBD.MensagemDeErro();

            this.Close();
        }

        private void tb_NomeAlt_Enter(object sender, EventArgs e)
        {
            lb_InfoUsuario.Visible = false;
            erroP.Clear();
        }
    }
}

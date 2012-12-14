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
    public partial class fm_Configurar : Form
    {
        public fm_Configurar()
        {
            InitializeComponent();
        }

        // Quando atualizaLV for verdadeiro é porque a necessida de atualizar o listview Amigos, pois, a quantidade de dias foi alterada então deve verificar se a usuarios com midias em atrazo, porém, com a nova quantidades de dias
        public bool atualizaLV = false;

        List<string> dadosAmigos;
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private void fm_Configurar_Load(object sender, EventArgs e)
        {
            if (GBD.AbrirConexao())
            {
                GBD.PreencherConfiguracoes(lb_qtdDias, lb_emailAntigo, lb_UsuarioAntigo, ck_DesabilitaLogin);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
        }

        //Verifica quais dados foram alterados e chama seu respectivo método na classe GBD passando por parâmetro em uma lista os dados para serem tratados e verificados. 
        private bool Alterar()
        {
            if (GBD.AbrirConexao())
            {
                dadosAmigos.Add(tb_nomeUsuario.Text);
                dadosAmigos.Add(tb_NovaSenha.Text);

                if (tb_SenhaAtual.Text != string.Empty && GBD.VerificarSenha(tb_SenhaAtual.Text))
                {
                    if (tb_qtdDias.Text != lb_qtdDias.Text && tb_qtdDias.Text != string.Empty)
                    {
                        GBD.Configurar(dadosAmigos, "AlterarQuantidadesDias");
                        atualizaLV = true;
                    }

                    if (tb_EmailPadrao.Text != string.Empty)
                        GBD.Configurar(dadosAmigos, "AlterarEmail");

                    if (tb_nomeUsuario.Text != string.Empty)
                        GBD.Configurar(dadosAmigos, "AlterarUsuario");

                    if (tb_NovaSenha.Text != string.Empty)
                        GBD.Configurar(dadosAmigos, "TrocarSenha");

                    System.Media.SystemSounds.Asterisk.Play();


                    GBD.FecharConexao();
                    return true;
                }
                else
                    lb_SenhaIncorreta.Visible = true;
            }
            else
                GBD.MensagemDeErro();
            GBD.FecharConexao();
            return false;
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void tb_SenhaAtual_Enter(object sender, EventArgs e)
        {
            lb_SenhaIncorreta.Visible = false;
        }
        private void bt_Confirma_Click(object sender, EventArgs e)
        {
            if (tb_NovaSenha.Text != string.Empty && tb_NovaSenha.Text != tb_ConfirmaSenha.Text)
            {
                // se senhas não se coincidirem os campos são limpos
                tb_NovaSenha.Text = string.Empty;
                tb_ConfirmaSenha.Text = string.Empty;
                lb_SenhasDiferentes.Visible = true;
                return;
            }
            if (tb_NovaSenha.Text.Count() != 6 && tb_NovaSenha.Text != string.Empty)
            {
                lb_SenhasDiferentes.Text = "✘ A senha deve conter 6 Carácter";
                lb_SenhasDiferentes.Visible = true;
                return;
            }
            lb_SenhasDiferentes.Visible = false;
            lb_SenhasDiferentes.Text = "✘ As senhas são Diferentes";

            Height = 173;
            panel1.Visible = true;
            tb_ConfirmaSenha.Visible = false;
            tb_NovaSenha.Visible = false;
            tb_SenhaAtual.Select();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fm_Configurar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dadosAmigos = new List<string>();
            // serve para armazanar no banco de dados caso estiver desabilitado seu valor sera 1 caso não sera 0
            if (ck_DesabilitaLogin.Checked)
                dadosAmigos.Add("1");
            else
                dadosAmigos.Add("0");
            GBD.AbrirConexao();
            GBD.Configurar(dadosAmigos, "DesabilitarBloqueio");
            GBD.FecharConexao();

        }

        private void tb_SenhaAtual_TextChanged(object sender, EventArgs e)
        {
            if (tb_SenhaAtual.Text.Count() == 6)
            {
                dadosAmigos = new List<string>();
                dadosAmigos.Add(lb_UsuarioAntigo.Text);
                dadosAmigos.Add(tb_SenhaAtual.Text);
                dadosAmigos.Add(tb_EmailPadrao.Text);
                dadosAmigos.Add(tb_qtdDias.Text);

                if (Alterar())
                    Close();
                else
                {
                    tb_SenhaAtual.Text = string.Empty;
                    erroP.SetError(tb_SenhaAtual, "Senha Incorreta");
                }
            }
                
        }
    }
}

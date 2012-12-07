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

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private void fm_Configurar_Load(object sender, EventArgs e)
        {

            GBD.AbrirConexao();

            GBD.PreencherConfiguracoes(lb_qtdDias, lb_emailAntigo, lb_UsuarioAntigo, ck_DesabilitaLogin);
            GBD.FecharConexao();

            tb_ConfirmaSenha.Visible = false;
            tb_EmailPadrao.Visible = false;
            tb_nomeUsuario.Visible = false;
            tb_NovaSenha.Visible = false;
            tb_qtdDias.Visible = false;
            tb_SenhaAtual.Visible = false;
            lb_ConfirmaSenha.Visible = false;
            lb_NovoNome.Visible = false;
            lb_NovaSenha.Visible = false;
            lb_SenhaAtual.Visible = false;
        }

        List<string> dadosAmigos;
        private void bt_ConfiguraOuOk_Click(object sender, EventArgs e)
        {
            dadosAmigos = new List<string>();
            dadosAmigos.Add(lb_UsuarioAntigo.Text);
            dadosAmigos.Add(tb_SenhaAtual.Text);
            dadosAmigos.Add(tb_EmailPadrao.Text);
            dadosAmigos.Add(tb_qtdDias.Text);
            if (ck_DesabilitaLogin.Checked)
                dadosAmigos.Add("1");
            else
                dadosAmigos.Add("0");

      
            if (bt_ConfiguraOuOk.Text == "OK")
            {
                Alterar();
                fm_Configurar_Load(null, null);
                return;
            }
            if (this.Height != 312)
            {
                this.Height += 125;
                tb_ConfirmaSenha.Visible = true;
                tb_EmailPadrao.Visible = true;
                tb_nomeUsuario.Visible = true;
                tb_NovaSenha.Visible = true;
                tb_qtdDias.Visible = true;
                tb_SenhaAtual.Visible = true;
                lb_ConfirmaSenha.Visible = true;
                lb_NovoNome.Visible = true;
                lb_NovaSenha.Visible = true;
                lb_SenhaAtual.Visible = true;
                bt_ConfiguraOuOk.Top += 121;
                bt_ConfiguraOuOk.Text = "OK";
            }
            
        }

        private void Alterar()
        {
           
            GBD.AbrirConexao();
            dadosAmigos.Add(tb_nomeUsuario.Text);
            dadosAmigos.Add(tb_NovaSenha.Text);
            
        
            if (tb_qtdDias.Text != lb_qtdDias.Text && tb_qtdDias.Text != string.Empty)
                GBD.Configurar(dadosAmigos, "AlterarQuantidadesDias");

            if (tb_EmailPadrao.Text != string.Empty)
                GBD.Configurar(dadosAmigos, "AlterarEmail");

            if (tb_nomeUsuario.Text != string.Empty)
                GBD.Configurar(dadosAmigos, "AlterarUsuario");

            if (tb_NovaSenha.Text != string.Empty && tb_NovaSenha.Text == tb_ConfirmaSenha.Text)
                GBD.Configurar(dadosAmigos, "TrocarSenha");

            GBD.Configurar(dadosAmigos, "DesabilitarLogin");

            GBD.FecharConexao();

            bt_Cancelar_Click(null, null);
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Height -= 125;
            bt_ConfiguraOuOk.Top -= 121;
            fm_Configurar_Load(sender, e);
            bt_ConfiguraOuOk.Text = "Configurar";
        }
    }
}

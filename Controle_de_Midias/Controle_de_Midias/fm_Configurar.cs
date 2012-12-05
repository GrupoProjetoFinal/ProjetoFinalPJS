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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int abilitarLogin = 0;
            if (button1.Text == "OK")
            {
                if (cb_DesabilitaLogin.Checked)
                    abilitarLogin = 1;
                GBD.AbrirConexao();
                GBD.Configurar(abilitarLogin);
                GBD.FecharConexao();
                bt_Cancelar_Click(sender, e);
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
                button1.Top += 121;
                button1.Text = "OK";
            }
            
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Height -= 125;
            button1.Top -= 121;
            fm_Configurar_Load(sender, e);
            button1.Text = "Configurar";
        }
    }
}

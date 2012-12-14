using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// Bibliotecas Adicionada

using System.Net.Mail;
using System.Drawing.Drawing2D;



namespace Controle_de_Midias
{
    public partial class fm_login : Form
    {
        MailMessage msg = new MailMessage();
        SmtpClient client = new SmtpClient();

        //essa matriz armazena a senha e o email do banco de dados
        private string[] senhaEmail = new string[2];
        
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        //serve para verificar se o usuario digitou a senha correta ou não após o fechamento deste formulário
        public bool logado = true;

        public fm_login()
        {
            InitializeComponent();
            
        }

        private void VerificaSenha()
        {
            if (GBD.AbrirConexao())
            {

                if (GBD.VerificarSenha(tb_Senha.Text))
                {
                    logado = true;
                    Close();
                }
                else
                {
                    tb_Senha.Clear();
                    erroP.SetError(tb_Senha, "Senha Inválida");
                    logado = false;
                }
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
            
        }

        private void bt_EnviarEmail_Click_1(object sender, EventArgs e)
        {
            try
            {

                SmtpClient smtp = new SmtpClient();
                msg = new MailMessage();
                msg.IsBodyHtml = true;
                smtp.EnableSsl = true;


                // credenciais do usuario 
                smtp.Credentials = new System.Net.NetworkCredential("collectors.medias@gmail.com", "projetoPJS");

                smtp.Port = 587;


                smtp.Host = "smtp.gmail.com";

                //quem enviara 
                msg.From = new MailAddress("collectors.medias@gmail.com");

                //pra quem sera enviado
                msg.To.Add(tb_email.Text);

                // Assunto da mesagem
                msg.Subject = "Solicitação de Senha ! ";

                //corpo da mensagem ou seja senha esquecida
                msg.Body = senhaEmail[1];
                
                //enviar mensagem
                smtp.Send(msg);

                lb_Enviado.Visible = true;
                lb_EmailIncorreto.Visible = false;
                lb_ConectarInternet.Visible = false;
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch (Exception err)
            {
                if (err.Message == "Failure sending mail.")
                {
                    lb_ConectarInternet.Visible = true;
                    lb_Enviado.Visible = false;
                    lb_EmailIncorreto.Visible = false;
                }
                else
                {
                    lb_EmailIncorreto.Visible = true;
                    lb_Enviado.Visible = false;
                    lb_ConectarInternet.Visible = false;
                }
                System.Media.SystemSounds.Hand.Play();
            }
        }

        private void fm_login_Load(object sender, EventArgs e)
        {
            tb_Senha.Select();
            pn_EnviaEmail.Visible = false;
            GBD.AbrirConexao();
            senhaEmail = GBD.PegarEmailSenha();
            tb_email.Text = senhaEmail[0];
            GBD.FecharConexao();

        }

        private void esqueciSenha_Click(object sender, EventArgs e)
        {
            erroP.Clear();
            pn_SolicitaSenha.Visible = false;
            pn_EnviaEmail.Visible = true;
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            pn_SolicitaSenha.Visible = true;
            pn_EnviaEmail.Visible = false;
        }

        private void fm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            VerificaSenha();
        }

        // A senha só sera verificada quando o usuário preencher os 6 caracteres
        private void tb_Senha_TextChanged(object sender, EventArgs e)
        {
            if (tb_Senha.Text.Count() == 6)
                VerificaSenha();
        }

        
    }
}

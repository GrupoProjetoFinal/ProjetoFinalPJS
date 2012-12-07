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

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        public bool logado = true;
        int contador = 0;
        public fm_login()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ++contador;
            if (contador == 6)
            {
                GBD.AbrirConexao();

                if (GBD.VerificarSenha(tb_Senha.Text))
                {
                    logado = true;
                    Close();
                }
                else
                    label2.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                SmtpClient smtp = new SmtpClient();
                msg = new MailMessage();
                msg.IsBodyHtml = true;
                smtp.EnableSsl = true;

                smtp.Credentials = new System.Net.NetworkCredential("collectors.medias@gmail.com", "projetoPJS");

                smtp.Port = 587;


                smtp.Host = "smtp.gmail.com";

                msg.From = new MailAddress("diego.germano.cj@gmail.com");

                msg.To.Add(tb_email.Text);

                msg.Subject = "ESQUECEU DA SENHA ";

                msg.Body = "EXEMPLO DE SENHA";
                
                smtp.Send(msg);

                MessageBox.Show("Sua senha foi enviada para o seu email !!!!!", "SUCESSOOOOOO");

            }
            catch (Exception ex)
            {
                MessageBox.Show("EROORORORO", "EROROROOR");
            }
        }

        private void fm_login_Load(object sender, EventArgs e)
        {
            pn_EnviaEmail.Visible = false;
            GBD.AbrirConexao();
            tb_email.Text =  GBD.PegarEmail();
            GBD.FecharConexao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pn_SolicitaSenha.Visible = false;
            pn_EnviaEmail.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_SolicitaSenha.Visible = true;
            pn_EnviaEmail.Visible = false;
        }


    }
}

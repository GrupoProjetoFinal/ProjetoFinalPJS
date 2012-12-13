using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Controle_de_Midias
{
    public partial class fm_AlterarAmigo : Form
    {
        public fm_AlterarAmigo()
        {
            InitializeComponent();
        }

        public bool alterarImagem = false;
        public bool alterar = false;
        public bool excluir = false;
        private GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        public Amigo NovoAmigo = new Amigo();
        private int idAmigo;
        List<string> dadosAmigos = new List<string>();

        //Preenche os TextBox com o item selecionado no ListView do fm_Principal.
        public void Preencher(Amigo rescrever)
        {
            GBD.AbrirConexao();
            dadosAmigos = GBD.ProcurarAmigo(rescrever.nome,rescrever.telefone,rescrever.email,rescrever.observacao);
            GBD.FecharConexao();

            tb_NomeAlt.Text = rescrever.nome;
            tb_TelefoneAlt.Text = rescrever.telefone;
            tb_EmailAlt.Text = rescrever.email;
            rtb_ObservacaoAlt.Text = rescrever.observacao;

            if (dadosAmigos[5] == string.Empty)
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";

            // Caso o usuario de algum modo excluir a imagem ele volta a imagem DESCONHECIDO
            try
            {
                pb_Amigo.Image = new Bitmap(dadosAmigos[5]);
            }
            catch (Exception err)
            {
                pb_Amigo.Image = new Bitmap(Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png");
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";
            }

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
                    if (alterarImagem || nomeAntigo != tb_NomeAlt.Text)
                    {
                        string NovoCaminho = Application.StartupPath + "\\FotosAmigos\\" + tb_NomeAlt.Text + idAmigo + ".png";
                        File.Copy(dadosAmigos[5], NovoCaminho, true);
                        GBD.FecharConexao();
                    }

                    alterar = true;
                }
                else
                    GBD.MensagemDeErro();

                this.Close();
         
            }
            else
            {  
                lb_InformaUsuario.Visible = true;
                erroP.SetError(lb_InformaUsuario, "O campo nome é obrigatório");
            }

        }

        private Amigo InserirDados()
        {
            
            // O conteúdo dos textBox são passados para o objeto Amigo.
            Amigo novoAmigo = new Amigo();

            NovoAmigo.imagem = Application.StartupPath.ToString() + "\\FotosAmigos\\" + tb_NomeAlt.Text + idAmigo+ ".png";
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
            lb_InformaUsuario.Visible = false;
            erroP.Clear();
        }
        private void bt_InserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "jpeg (*.jpeg*)|*.jpeg*";
            // Abre caixa de dialogo para o usuáio escolher a imagem
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                alterarImagem = true;
                dadosAmigos[5] = Dialogo.FileName;
                pb_Amigo.Image.Dispose();
                pb_Amigo.Image = new Bitmap(dadosAmigos[5]);
            }
        }
        public string nomeAntigo;
        private void fm_AlterarAmigo_Load(object sender, EventArgs e)
        {
            nomeAntigo = tb_NomeAlt.Text;
        }
    }
}

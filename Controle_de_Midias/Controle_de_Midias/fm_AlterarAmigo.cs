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

        private GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        public Amigo NovoAmigo = new Amigo();

        //Usado para nome da imagem para que ela seja univca  
        private int idAmigo;
        //Verifica se  o usuário trocou a imagem original
        public bool alterarImagem = false;

        //Retorna para o fm_principal atualizar o Listview
        public bool alterar = false;
        public bool excluir = false;

        //usado para armazenar o nome inicial do amigo antes da alteração
        public string nomeAntigo;

        List<string> dadosAmigos = new List<string>();

        //Preenche os TextBox com o item selecionado no ListView do fm_Principal.
        public string Preencher(Amigo amigo)
        {
            GBD.AbrirConexao();
            dadosAmigos = GBD.ProcurarAmigo(amigo.nome,amigo.telefone,amigo.email,amigo.observacao);
            GBD.FecharConexao();

            tb_NomeAlt.Text = amigo.nome;
            tb_TelefoneAlt.Text = amigo.telefone;
            tb_EmailAlt.Text = amigo.email;
            rtb_ObservacaoAlt.Text = amigo.observacao;

            //caso o campo do caminho da imagem dadosAmigos[5] seja vazio ele é atribuido ao caminho da imagem desconhecido 
            if (dadosAmigos[5] == string.Empty)
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";

            // Caso o usuario de algum modo excluir a imagem ela volta a ser imagem DESCONHECIDO
            if(File.Exists(dadosAmigos[5]))
                pb_Amigo.Image = new Bitmap(dadosAmigos[5]);
            else
            {
                pb_Amigo.Image = new Bitmap(Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png");
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";
            }

            if (GBD.AbrirConexao())
            {
                idAmigo = GBD.PegarIdentificadorAmigo(amigo);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();

            return dadosAmigos[5];
        }

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            // o campo nome do amigo é obrigatório
            if (tb_NomeAlt.Text != string.Empty)
            {
                if (GBD.AbrirConexao())
                {
                    //altera o caminho da imagem no banco de dados caso houver a troca da imagem original ou do nome do usuário que é usado para nomear a imagem
                    GBD.AlteraAmigo(InserirDados());
                    if (alterarImagem || nomeAntigo != tb_NomeAlt.Text)
                    {
                        string NovoCaminho = Application.StartupPath + "\\FotosAmigos\\" + tb_NomeAlt.Text + idAmigo + ".png";
                        File.Copy(dadosAmigos[5], NovoCaminho, true);
                        GBD.FecharConexao();
                    }

                    //usado para atualizar o listview do formulário principal 
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

            return NovoAmigo;
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            //Verifica se a conecção foi aberta, se sim executa o comando SLQ no GerenciadorDeBanco.
            if (GBD.AbrirConexao())
            {
                GBD.Remover(InserirDados());
                GBD.FecharConexao();
                //usado para atualizar o listview do formulário principal
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

            //Faz o filtro somente por imagens evitando a escolha de outros arquivos não suportados pelo picturebox
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
        private void fm_AlterarAmigo_Load(object sender, EventArgs e)
        {
            nomeAntigo = tb_NomeAlt.Text;
        }
    }
}

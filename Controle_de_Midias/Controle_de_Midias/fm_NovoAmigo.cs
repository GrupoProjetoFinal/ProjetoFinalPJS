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
    public partial class fm_NovoAmigo : Form
    {
        ListView lvAmigo;
        private bool salvarImagem = false;
        public fm_NovoAmigo(ListView fmAmigoLista)
        {
            //Recebe a referencia do listView vinda do fm_pricipal e passa para o listview lvMidias
            lvAmigo = fmAmigoLista;
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_Nome.Text == string.Empty)
            {
                lb_InfoUsuario.Visible = true;
                Erro.SetError(lb_InfoUsuario, "O campo nome é obrigatório");
                return;
            }

            Amigo novoAmigo = new Amigo();

            if (salvarImagem)
            {
                pb_Amigo.Image.Save(Application.StartupPath.ToString() + "\\FotosAmigos\\" + tb_Nome.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                novoAmigo.imagem = Application.StartupPath.ToString() + "\\FotosAmigos\\" + tb_Nome.Text + ".png";
            }
            else
                novoAmigo.imagem = string.Empty;

            novoAmigo.nome = tb_Nome.Text;
            novoAmigo.telefone = tb_Telefone.Text;
            novoAmigo.email = tb_Email.Text;
            novoAmigo.observacao = rtb_Observacao.Text;

            GerenciadorDeBanco GBD = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (GBD.AbrirConexao())
            {
                GBD.InserirAmigo(novoAmigo);
                GBD.FecharConexao();

                //Limpa os textBox
                bt_Limpar_Click(sender, e);
                pn_imgDesconecido.Visible = true;
                //Adiciona a nova midia no ListView lvMidias.
                ListViewItem item;

                item = new ListViewItem(novoAmigo.nome);
                lvAmigo.Items.Add(item);
                item.SubItems.Add(novoAmigo.telefone);
                item.SubItems.Add(novoAmigo.email);
                item.SubItems.Add(novoAmigo.observacao);
                System.Media.SystemSounds.Asterisk.Play();

            }
            else
                GBD.MensagemDeErro();
        }
        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            lb_InfoUsuario.Visible = false;
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_Email.Clear();
            tb_Nome.Clear();
            tb_Telefone.Clear();
            rtb_Observacao.Clear();
        }

        private void bt_InserirImagem_Click(object sender, EventArgs e)
        {
            //Abre caixa de dialogo para o usuáio escolher a imagem
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "jpeg (*.jpeg*)|*.jpeg*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                salvarImagem = true;
                pn_imgDesconecido.Visible = false;
                try
                {
                    Bitmap imagem = new Bitmap(openFileDialog1.FileName);
                    pb_Amigo.Image = imagem;
                }
                catch
                {
                    salvarImagem = false;
                    pn_imgDesconecido.Visible = true;
                }
            }
        }

    }
}


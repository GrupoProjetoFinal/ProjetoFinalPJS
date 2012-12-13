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
    public partial class fm_CadMidias : Form
    {
        ListView lvMidias;

        //recebe o ListView do fm_principal por parâmetro assim ele é atualizado quando for adicionado uma nova mida.

        public fm_CadMidias(ListView fmMidiasLista)
        {

            InitializeComponent();
            
            //lvMidias pega a referência do Listview do formulário principal;
            lvMidias = fmMidiasLista;
            cb_Nota.SelectedIndex = 0;
            cb_Tipomidia.SelectedIndex = 0;
        }

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        Midia midia = new Midia();

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            if (cb_Tipomidia.SelectedIndex != 4)
            {
                if (tb_Album.Text == string.Empty)
                {
                    lb_InfoUsuario.Text = "O Campo Álbum e obrigatório";
                    lb_InfoUsuario.Visible = true;
                    erroP.SetError(lb_InfoUsuario, "O campo é obrigatório");
                    return;
                }
            }
            else if (tb_Nomemusica.Text == string.Empty)
            {
                lb_InfoUsuario.Text = "O Campo Nome Música e obrigatório";
                lb_InfoUsuario.Visible = true;
                erroP.SetError(lb_InfoUsuario, "O campo é obrigatório");
                return;
            }

                if (GBD.AbrirConexao())
                {
                    // adiciona os atributos no objeto Midia
                    midia.interprete = tb_Interprete.Text;
                    midia.autor = tb_Autor.Text;
                    midia.musica = tb_Nomemusica.Text;
                    midia.album = tb_Album.Text;
                    midia.dataAlbum = dtp_DataAlbum.Value;
                    midia.dataCompra = dtp_DataCompra.Value;
                    midia.compra = tb_Origemcompra.Text;
                    midia.tipo = cb_Tipomidia.SelectedIndex;
                    midia.observacao = rtb_Observacao.Text;
                    midia.nota = cb_Nota.Text;

                    GBD.CadastroMidia(midia);
                    GBD.FecharConexao();
                }
                else
                    GBD.MensagemDeErro();


                //Adiciona a nova midia no ListView lvMidias.
                ListViewItem item;

                item = new ListViewItem("♫   "+midia.album);
                item.Group = lvMidias.Groups[midia.tipo];
                lvMidias.Items.Add(item);
                item.SubItems.Add(midia.interprete);
                item.SubItems.Add(midia.autor);
                item.SubItems.Add(midia.musica);
                item.SubItems.Add(midia.nota);
                item.SubItems.Add(midia.dataCompra.ToShortDateString());
                item.SubItems.Add(midia.dataAlbum.ToLongDateString());
                item.SubItems.Add(midia.compra);
                item.SubItems.Add(midia.observacao);

                //Limpar campos apos a inserção
                bt_Limpar_Click(sender, e);
                System.Media.SystemSounds.Asterisk.Play();          
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_Interprete.Text = string.Empty;
            tb_Autor.Text = string.Empty;
            tb_Album.Text = string.Empty;
            tb_Nomemusica.Text = string.Empty;
            tb_Origemcompra.Text = string.Empty;
            cb_Nota.SelectedIndex = 0;
            cb_Tipomidia.SelectedIndex = 0;
            rtb_Observacao.Text = string.Empty;
        }


    
    }
}

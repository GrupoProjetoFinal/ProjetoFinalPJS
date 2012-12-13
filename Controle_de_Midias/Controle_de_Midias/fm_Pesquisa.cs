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
    public partial class fm_Pesquisa : Form
    {
        public fm_Pesquisa()
        {
            InitializeComponent();
        }

        Midia midia = new Midia();
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private void fm_Pesquisa_Load(object sender, EventArgs e)
        {
            cb_Nota.SelectedIndex = 0;
            cb_Tipomidia.SelectedIndex = 0;
            ckb_QualquerData.Checked = true;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            bool qualquerData = false;
            DateTime dataAlbumFIM;
            DateTime dataCompraFIM;

            if (cb_Tipomidia.Text == "Todas")
                midia.tipo = -1;
            else
                midia.tipo = cb_Tipomidia.SelectedIndex - 1;
            if (ckb_QualquerData.Checked)
                qualquerData = true;
            

            dataAlbumFIM = dtp_DataAlbum_ATE.Value;
            dataCompraFIM = dtp_DataCompra_ATE.Value;
            midia.interprete = tb_Interprete.Text;
            midia.autor = tb_Autor.Text;
            midia.nota = cb_Nota.Text;
            midia.musica = tb_Nomemusica.Text;
            midia.album = tb_Album.Text;
            midia.dataAlbum = dtp_DataAlbum_DE.Value;
            midia.dataCompra = dtp_DataCompra_DE.Value;
            midia.compra = tb_Origemcompra.Text;
            midia.observacao = rtb_Observacao.Text;
            if (GBD.AbrirConexao())
            {
                GBD.ProcurarMidia(lv_MidiasP, midia, dataCompraFIM, dataAlbumFIM, qualquerData);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();

        }

        private void lv_MidiasP_DoubleClick(object sender, EventArgs e)
        {

            // Os dados selecionados no ListView são passados para o objeto Midia.
            Midia infMidia = new Midia();

            foreach (ListViewItem item in lv_MidiasP.SelectedItems)
            {
                infMidia.album = item.Text;
                infMidia.interprete = item.SubItems[1].Text;
                infMidia.autor = item.SubItems[2].Text;
                infMidia.musica = item.SubItems[3].Text;
                infMidia.nota = item.SubItems[4].Text;
                infMidia.dataCompra = DateTime.Parse(item.SubItems[5].Text);
                infMidia.dataAlbum = DateTime.Parse(item.SubItems[6].Text);
                infMidia.compra = item.SubItems[7].Text;
                infMidia.observacao = item.SubItems[8].Text;
                infMidia.tipo = lv_MidiasP.Groups.IndexOf(item.Group);
            }

            // Chama o método Preecher do Form fm_AlterarMidia, em seguida abre-o.
            fm_AlterarMidia ModificarMidia = new fm_AlterarMidia();

            ModificarMidia.Preencher(infMidia);
            ModificarMidia.ShowDialog();

            //Caso o amigo for alterado retorna verdadeiro e altera Listview caso não ele é excluido
            if (ModificarMidia.alterar)
                foreach (ListViewItem item in lv_MidiasP.SelectedItems)
                {

                    item.Text = ModificarMidia.NovaMidia.album;
                    item.Group = lv_MidiasP.Groups[ModificarMidia.NovaMidia.tipo];
                    item.SubItems[1].Text = ModificarMidia.NovaMidia.interprete;
                    item.SubItems[2].Text = ModificarMidia.NovaMidia.autor;
                    item.SubItems[3].Text = ModificarMidia.NovaMidia.musica;
                    item.SubItems[4].Text = ModificarMidia.NovaMidia.nota;
                    item.SubItems[5].Text = ModificarMidia.NovaMidia.dataCompra.ToString();
                    item.SubItems[6].Text = ModificarMidia.NovaMidia.dataAlbum.ToString();
                    item.SubItems[7].Text = ModificarMidia.NovaMidia.compra;
                    item.SubItems[8].Text = ModificarMidia.NovaMidia.observacao;
                }
            else if (ModificarMidia.excluir)
                foreach (ListViewItem item in lv_MidiasP.SelectedItems)
                    item.Remove();
        
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_Album.Text= string.Empty;
            tb_Autor.Text = string.Empty;
            tb_Interprete.Text = string.Empty;
            tb_Nomemusica.Text = string.Empty;
            tb_Origemcompra.Text = string.Empty;
            cb_Nota.SelectedIndex = 0;
            cb_Tipomidia.SelectedIndex = 0;
          
        }

    }
}

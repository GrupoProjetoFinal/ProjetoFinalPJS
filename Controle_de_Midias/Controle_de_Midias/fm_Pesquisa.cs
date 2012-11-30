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

        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            midia.interprete = tb_Interprete.Text;
            midia.autor = tb_Autor.Text;
            midia.musica = tb_Nomemusica.Text;
            midia.album = tb_Album.Text;
            midia.dataAlbum = dtp_DataAlbum.Value;
            midia.dataCompra = dtp_DataCompra.Value;
            midia.compra = tb_Origemcompra.Text;
            midia.tipo = cb_Tipomidia.SelectedIndex;
            midia.observacao = rtb_Observacao.Text;

            GBD.AbrirConexao();
            GBD.ProcurarMidia(lv_MidiasP,midia);
            GBD.FecharConexao();

        }
    }
}

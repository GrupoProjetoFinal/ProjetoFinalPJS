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
        public fm_CadMidias()
        {
            InitializeComponent();
        }

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        Midia midia = new Midia();

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            GBD.AbrirConexao();

            midia.interprete = tb_Interprete.Text;
            midia.autor = tb_Autor.Text;
            midia.musica = tb_Nomemusica.Text;
            midia.album = tb_Album.Text;
            midia.dataAlbum = dtp_DataAlbum.Value;
            midia.dataCompra = dtp_DataCompra.Value;
            midia.compra = tb_Origemcompra.Text;
            midia.tipo = cb_Tipomidia.Text;
            midia.observacao = rtb_Observacao.Text;

            GBD.CadastroMidia(midia);


            GBD.FecharConexao();


        }

      
       
    }
}

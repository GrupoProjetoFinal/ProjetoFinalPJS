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
            cb_Nota.SelectedIndex = 0;
            cb_Tipomidia.SelectedIndex = 0;
        }

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        Midia midia = new Midia();

        
        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            if (tb_Album.Text != "" && cb_Tipomidia.SelectedIndex != 0)
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
                midia.nota = cb_Nota.Text;

                GBD.CadastroMidia(midia);


                GBD.FecharConexao();


                //Limpar campos apos a inserção
                tb_Interprete.Text = "";
                tb_Autor.Text = "";
                tb_Album.Text = "";
                tb_Nomemusica.Text = "";
                tb_Origemcompra.Text = "";
                cb_Nota.SelectedIndex = 0;
                cb_Tipomidia.SelectedIndex = 0;
                rtb_Observacao.Text = "";
            }
            else
            {
                //arrumar como apresentar o tratamento de erro
                MessageBox.Show("Erro ao cadastrar");

            }
            
           
        }

        private void fm_CadMidias_Load(object sender, EventArgs e)
        {

        }

     
      
       
    }
}

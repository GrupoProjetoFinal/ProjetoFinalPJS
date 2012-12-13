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
    public partial class fm_AlterarMidia : Form
    {
        public fm_AlterarMidia()
        {
            InitializeComponent();
        }

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        public Midia NovaMidia = new Midia();
        private int idMidia;

        // São usadas para que no fm_principal saiba qual ação deve ser feita
        public bool alterar = false;
        public bool excluir = false;

        public void Preencher(Midia rescrever)
        {
            int cont = 0;
            string album = string.Empty;
            while (cont <= rescrever.album.Count() - 1)
            {
                if (cont > 3)
                    album += rescrever.album[cont];
                ++cont;
            }

            // Insere os atributos do objeto para os TextBox.
            tb_altAutor.Text = rescrever.autor;
            tb_altInterprete.Text = rescrever.interprete;
            tb_altOrigemcompra.Text = rescrever.compra;
            tb_altNomemusica.Text = rescrever.musica;
            tb_altAlbum.Text = album;
            cb_altNota.Text = rescrever.nota;
            dtp_altDataAlbum.Value = rescrever.dataAlbum;
            dtp_altDataCompra.Value = rescrever.dataCompra;
            rtb_altObservacao.Text = rescrever.observacao;
            cb_altTipomidia.SelectedIndex = rescrever.tipo;

            if (GBD.AbrirConexao())
            {
                idMidia = GBD.PegaIdentificadorMidias(rescrever);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
        }


        private void bt_Apagar_Click(object sender, EventArgs e)
        {
            //Verifica se a conecção foi aberta, se sim executa o comando SLQ no GerenciadorDeBanco.
            if (GBD.AbrirConexao())
            {
                GBD.ExcluirMidia(InserirDados());
                GBD.FecharConexao();
                excluir = true;
            }
            else
                GBD.MensagemDeErro();

            this.Close();
        }

        private Midia InserirDados()
        {
            NovaMidia.id = idMidia;
            NovaMidia.autor = tb_altAutor.Text;
            NovaMidia.interprete = tb_altInterprete.Text; 
            NovaMidia.compra = tb_altOrigemcompra.Text;
            NovaMidia.musica = tb_altNomemusica.Text;
            NovaMidia.album = tb_altAlbum.Text; 
            NovaMidia.nota = cb_altNota.Text;
            NovaMidia.dataAlbum = dtp_altDataAlbum.Value;
            NovaMidia.dataCompra = dtp_altDataCompra.Value;
            NovaMidia.observacao = rtb_altObservacao.Text;
            NovaMidia.tipo = cb_altTipomidia.SelectedIndex;

            // O conteúdo dos TextBox são passados para o objeto NovaMidia.
            return NovaMidia;
        }

        private void bt_Alterar_Click_1(object sender, EventArgs e)
        {

            if (GBD.AbrirConexao())
            {
                GBD.AlterarMidia(InserirDados());
                GBD.FecharConexao();
                alterar = true;
            }
            else
                GBD.MensagemDeErro();

            this.Close();
        }


      
    }
}

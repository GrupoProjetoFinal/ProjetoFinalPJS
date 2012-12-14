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

        // São usadas para que no fm_principal saiba qual ação deve ser feita na atualização do ListView
        public bool alterar = false;
        public bool excluir = false;

        public void Preencher(Midia midia)
        {
            // Insere os atributos do objeto para os TextBox.
            tb_altAutor.Text = midia.autor;
            tb_altInterprete.Text = midia.interprete;
            tb_altOrigemcompra.Text = midia.compra;
            tb_altNomemusica.Text = midia.musica;
            //retira o caracter especial da string 
            tb_altAlbum.Text = GBD.RetiraIcone(midia.album);
            cb_altNota.Text = midia.nota;
            dtp_altDataAlbum.Value = midia.dataAlbum;
            dtp_altDataCompra.Value = midia.dataCompra;
            rtb_altObservacao.Text = midia.observacao;
            cb_altTipomidia.SelectedIndex = midia.tipo;

            if (GBD.AbrirConexao())
            {
                idMidia = GBD.PegaIdentificadorMidias(midia);
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
                //usado para atualizar o listview do formulário principal
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

            return NovaMidia;
        }

        private void bt_Alterar_Click_1(object sender, EventArgs e)
        {
            if (cb_altTipomidia.SelectedIndex != 4)
            {
                if (tb_altAlbum.Text == string.Empty)
                {
                    lb_InfoUsuario.Text = "O Campo Álbum e obrigatório";
                    lb_InfoUsuario.Visible = true;
                    erroP.SetError(lb_InfoUsuario, "O campo é obrigatório");
                    return;
                }
            }
            else if (tb_altNomemusica.Text == string.Empty)
            {
                lb_InfoUsuario.Text = "O Campo Nome Música e obrigatório";
                lb_InfoUsuario.Visible = true;
                erroP.SetError(lb_InfoUsuario, "O campo é obrigatório");
                return;
            }


            if (GBD.AbrirConexao())
            {
                GBD.AlterarMidia(InserirDados());
                GBD.FecharConexao();
                //usado para atualizar o listview do formulário principal
                alterar = true;
            }
            else
                GBD.MensagemDeErro();

            this.Close();
        }
    }
}

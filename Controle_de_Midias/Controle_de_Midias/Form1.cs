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
     
    public partial class fm_Principal : Form
    {
        public fm_Principal()
        {
            InitializeComponent();
        }


        private bool lvAtivado;
        private int qtd_AnteriorCaracter = 0;
        List<ListViewItem> amigos = new List<ListViewItem>();
        List<ListViewItem> midias = new List<ListViewItem>();
        const string formulario = "fm_Principal";
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        
        private void fm_Principal_Load(object sender, EventArgs e)
        {
            //serve para verificar se a midia emprestadas pois se for igual a 0 o botão DEVOLVER fica desativado 
            int contador;
            if (GBD.AbrirConexao())
            {
                contador = GBD.ContarRegistros();
                GBD.PreencherLvMidias(lv_Midias, 0);
                GBD.PreecherLvAmigos(lv_Amigos, formulario);
                GBD.AcrecentaDias();
                GBD.FecharConexao();
                if (contador == 0)
                    bt_Devolver.Enabled = false;
            }
            else
                GBD.FecharConexao();
        }

        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            fm_Emprestimo emprestimo = new fm_Emprestimo();
            emprestimo.ShowDialog();

            if (emprestimo.verificador)
                bt_Devolver.Enabled = true;
        }

        private void bt_NovoAmigo_Click(object sender, EventArgs e)
        {
            fm_NovoAmigo Adicionar = new fm_NovoAmigo(lv_Amigos);
            Adicionar.ShowDialog();
        }

        private void lv_Amigos_DoubleClick(object sender, EventArgs e)
        {
            // Os dados selecionados no ListView são passados para o objeto Amigo.
            Amigo ModificaAmigo = new Amigo();
            foreach (ListViewItem item in lv_Amigos.SelectedItems)
            {
                ModificaAmigo.nome = item.Text;
                ModificaAmigo.telefone = item.SubItems[1].Text;
                ModificaAmigo.email = item.SubItems[2].Text;
                ModificaAmigo.observacao = item.SubItems[3].Text;
            }

            // Chama o método Preecher do Form fm_AlterarAmigo, em seguida abre-o.
            fm_AlterarAmigo AlterarAmigo = new fm_AlterarAmigo();
            AlterarAmigo.Preencher(ModificaAmigo);
            AlterarAmigo.ShowDialog();

            //Caso o amigo for alterado retorna verdadeiro e altera Listview caso não ele é excluido
            if (AlterarAmigo.alterar)
                foreach (ListViewItem item in lv_Amigos.SelectedItems)
                {
                    item.Text = AlterarAmigo.NovoAmigo.nome;
                    item.SubItems[1].Text = AlterarAmigo.NovoAmigo.telefone;
                    item.SubItems[2].Text = AlterarAmigo.NovoAmigo.email;
                    item.SubItems[3].Text = AlterarAmigo.NovoAmigo.observacao;
                }
            else if(AlterarAmigo.excluir)
                foreach (ListViewItem item in lv_Amigos.SelectedItems)
                    item.Remove();
        }

        private void bt_Devolver_Click(object sender, EventArgs e)
        {
            fm_Devolver devolver = new fm_Devolver();
            devolver.ShowDialog();

            if (devolver.LvVazio)
                bt_Devolver.Enabled = false;
        }

        private void bt_NovaMidia_Click(object sender, EventArgs e)
        {
            fm_CadMidias novaMidia = new fm_CadMidias(lv_Midias);
            novaMidia.ShowDialog();
        }

        private void lv_Midias_DoubleClick(object sender, EventArgs e)
        {
            // Os dados selecionados no ListView são passados para o objeto Midia.
            Midia infMidia = new Midia();
           
            foreach (ListViewItem item in lv_Midias.SelectedItems)
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
                infMidia.tipo = lv_Midias.Groups.IndexOf(item.Group);
            }

            // Chama o método Preecher do Form fm_AlterarMidia, em seguida abre-o.
            fm_AlterarMidia ModificarMidia = new fm_AlterarMidia();

            ModificarMidia.Preencher(infMidia);
            ModificarMidia.ShowDialog();

            //Caso o amigo for alterado retorna verdadeiro e altera Listview caso não ele é excluido
            if (ModificarMidia.alterar)
                foreach (ListViewItem item in lv_Midias.SelectedItems)
                {

                    string icone = "♫   ";

                    item.Text = icone+ModificarMidia.NovaMidia.album;
                    item.Group = lv_Midias.Groups[ModificarMidia.NovaMidia.tipo];
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
                foreach (ListViewItem item in lv_Midias.SelectedItems)
                    item.Remove();
        }
        
        private void bt_Pesquisa_Click(object sender, EventArgs e)
        {
             fm_Pesquisa pesquisa = new fm_Pesquisa();
            pesquisa.ShowDialog();
        }

        public void PesquisaParcial_TextChanged(object sender, EventArgs e)
        {
            // qtd_AnteriorCaracter serve para que o valor da quantidade dos caracters não se perca
            qtd_AnteriorCaracter = GBD.PesquisaParcialAmigo(lv_Amigos, tb_PesquisaParcial.Text, qtd_AnteriorCaracter);
            
        }

        private void tb_PesquisaParcialM_TextChanged(object sender, EventArgs e)
        {
            //Se quantidade anterior de caracter for maior que a atual o usuário apertou Backspace
            qtd_AnteriorCaracter = GBD.PesquisaParcialMidia(lv_Midias, tb_PesquisaParcialM.Text, qtd_AnteriorCaracter);
        }
        
        private void bt_Configrar_Click(object sender, EventArgs e)
        {
            fm_Configurar configurar = new fm_Configurar();
            configurar.ShowDialog();
            if (configurar.atualizaLV)
            {
                lv_Amigos.Items.Clear();
                if (GBD.AbrirConexao())
                {
                    GBD.PreecherLvAmigos(lv_Amigos, formulario);
                    GBD.FecharConexao();
                }
                else
                    GBD.MensagemDeErro();
            
            }
            
        }

        private void lv_Midias_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (sender == lv_Midias)
                lvAtivado = true;
            else
                lvAtivado = false;

            bt_Alterar.Enabled = true;   
        }
        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            if (lvAtivado)
                lv_Midias_DoubleClick(sender, e);
            else
                lv_Amigos_DoubleClick(sender, e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_Alterar.Enabled = false;
        }

    }
 }

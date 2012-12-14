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
     
    public partial class fm_Principal : Form
    {
        public fm_Principal()
        {
            InitializeComponent();
        }

        //usado para controlar a visualização da imagem dos amigos 
        private int contador = 0;
        private int inicio = 0;

        //usado para verificar se a algum item selecionado tanto no Lv_Amigo quanto no Lv_Midias
        private bool lvAtivado;
        private int qtd_AnteriorCaracter = 0;
        private const string formulario = "fm_Principal";
        List<string> dadosAmigos = new List<string>();
        List<ListViewItem> amigos = new List<ListViewItem>();
        List<ListViewItem> midias = new List<ListViewItem>();
        Amigo amigo = new Amigo();
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
                //Atualiza dias que a midia esta emprestada
                GBD.AtualizaDias();
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
            Devolver devolver = new Devolver();
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

        private void bt_Proximo_Click(object sender, EventArgs e)
        {
            ++contador;
            rb_Individual_Click(null, null);
        }

        private void bt_Anterior_Click(object sender, EventArgs e)
        {
            --contador;
            rb_Individual_Click(null, null);

        }

        private void rb_Lista_Click(object sender, EventArgs e)
        {
            if(pb_Amigo.Image != null)
                pb_Amigo.Image.Dispose();
            pn_Amigo.Visible = false;
            lv_Amigos.Visible = true;
        }

        private void rb_Individual_Click(object sender, EventArgs e)
        {
            if (contador < 0)
                contador = 0;
            inicio = 0;
            lv_Amigos.Visible = false;
            pn_Amigo.Visible = true;
            // percorre todos os item do lv_amigos paralelamente com a variavél inicio, exemplo se o usuario estiver no amigo 10, quando inicio for igual a contador ele pega os dados do item vai no banco de dados pega o caminho da imagem e coloca no picturebox
            foreach (ListViewItem item in lv_Amigos.Items)
            {

                lb_Nome.Text = item.SubItems[0].Text;
                lb_Telefone.Text = item.SubItems[1].Text;
                lb_email.Text = item.SubItems[2].Text;
                lb_observacao.Text = item.SubItems[3].Text;
                if (inicio == contador)
                {
                    amigo.nome = item.Text;
                    amigo.telefone = item.SubItems[1].Text;
                    amigo.email = item.SubItems[2].Text;
                    amigo.observacao = item.SubItems[3].Text;
                    if(pb_Amigo.Image != null)
                        pb_Amigo.Image.Dispose();

                    pb_Amigo.Image = new Bitmap(ObterImagem());
                    return;
                }
                inicio++;
            }
            //caso essa linha for executada é porque o usuário chegou no ultimo amigo, assim o contador e direcionado ao primeiro amigo
            contador = 0;
        }

        public string ObterImagem()
        {
            string endImagem;
            GBD.AbrirConexao();
            dadosAmigos = GBD.ProcurarAmigo(amigo.nome, amigo.telefone, amigo.email, amigo.observacao);
            GBD.FecharConexao();

            
            if (dadosAmigos[5] == string.Empty)
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";

            // Caso o usuario de algum modo excluir a imagem ele volta a imagem DESCONHECIDO

            if(!File.Exists(dadosAmigos[5]))
            {
                dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";
            }
            return endImagem = dadosAmigos[5];
        }
    }
 }

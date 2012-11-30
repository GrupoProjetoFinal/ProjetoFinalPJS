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

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        fm_Emprestimo emprestimo = new fm_Emprestimo();
        fm_Devolver devolver = new fm_Devolver();
        fm_AlterarAmigo AlterarAmigo = new fm_AlterarAmigo();
        fm_Pesquisa pesquisa = new fm_Pesquisa();

        // como faz para uma string assumir um valor inicial so na primeira vez em um metodo ex
        
        private void fm_Principal_Load(object sender, EventArgs e)
        {
            GBD.AbrirConexao();
            GBD.PreencherLvMidias(lv_Midias,0);
            GBD.PreecherLvAmigos(lv_Amigos, "fm_Principal");
            GBD.AcrecentaDias();
            GBD.FecharConexao();
        }

        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            emprestimo.ShowDialog();
        }

        private void bt_NovoAmigo_Click(object sender, EventArgs e)
        {
            fm_NovoAmigo Adicionar = new fm_NovoAmigo();
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
            devolver.ShowDialog();
        }

        private void bt_NovaMidia_Click(object sender, EventArgs e)
        {
            fm_CadMidias novaMidia = new fm_CadMidias();
            novaMidia.ShowDialog();
        }

        private void lv_Midias_DoubleClick(object sender, EventArgs e)
        {
            // Os dados selecionados no ListView são passados para o objeto Midia.
            fm_AlterarMidia ModificarMidia = new fm_AlterarMidia();

            Midia modificaMidia = new Midia();
            foreach (ListViewItem item in lv_Amigos.SelectedItems)
            {
                modificaMidia.autor = item.Text;
                modificaMidia.interprete = item.SubItems[1].Text;
                modificaMidia.compra = item.SubItems[2].Text;
                modificaMidia.autor = item.SubItems[3].Text;
                modificaMidia.musica = item.SubItems[4].Text;
                modificaMidia.nota = item.SubItems[5].Text;
                modificaMidia.dataAlbum = DateTime.Parse(item.SubItems[6].Text);
                modificaMidia.dataCompra = DateTime.Parse(item.SubItems[7].Text);
                modificaMidia.observacao = item.SubItems[8].Text;
            }

            // Chama o método Preecher do Form fm_AlterarAmigo, em seguida abre-o.
            //fm_AlterarMidia ModificarMidia = new fm_AlterarMidia();
            //ModificarMidia.(modificaMidia);
            //ModificarMidia.ShowDialog();

            fm_CadMidias Cadastro_Midia = new fm_CadMidias();
            Cadastro_Midia.ShowDialog();
        }

        private void bt_Pesquisa_Click(object sender, EventArgs e)
        {
            pesquisa.ShowDialog();
        }
        private int i = 0;
        string nome = null;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //char[] teste = new char[50];
            //List<char> teste2 = new List<char>();
            //while (textBox1.Text.Count() > 0)
            //{
            //    teste2.Add(textBox1.Text[textBox1.Text.Count()]);
            //}
            //while (i <= (teste2.Count() - 1))
            //{
            //    nome += teste2[i];
            //    ++i;
            //}

            if (textBox1.Text == nome)
            {
                GBD.AbrirConexao();
                GBD.PreecherLvAmigos(lv_Amigos, "fm_Principal");
                foreach (ListViewItem item in lv_Amigos.Items)
                    if (!item.Text.Contains(textBox1.Text))
                        item.Remove();
            }
            foreach (ListViewItem item in lv_Amigos.Items)
                if (!item.Text.Contains(textBox1.Text))
                    item.Remove();

        //    
   
        }

    }
}

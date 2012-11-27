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

    }
}

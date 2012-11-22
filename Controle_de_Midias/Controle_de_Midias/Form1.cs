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
        
        private void fm_Principal_Load(object sender, EventArgs e)
        {
            GBD.AbrirConexao();
            GBD.PreencherLvMidias(lv_Midias);
            GBD.PreecherLvAmigos(lv_Amigos);
            GBD.FecharConexao();



            //retorna a diferença de dias de duas datas
            string cmdSQL = " SELECT DATEDIFF ( DAY , '11/20/2012' , GETDATE())";
        }

        private void gb_Midias_Enter(object sender, EventArgs e)
        {

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
            //int DadosModificar;

            Amigo ModificaAmigo = new Amigo();
            foreach (ListViewItem item in lv_Amigos.SelectedItems)
            {
                ModificaAmigo.nome = item.Text;
                ModificaAmigo.telefone = item.SubItems[1].Text;
                ModificaAmigo.email = item.SubItems[2].Text;
                ModificaAmigo.observacao = item.SubItems[3].Text;
                ModificaAmigo.anterior.Add(item.Text);
                ModificaAmigo.anterior.Add(item.SubItems[1].Text);
                ModificaAmigo.anterior.Add( item.SubItems[2].Text);
                ModificaAmigo.anterior.Add(item.SubItems[3].Text);


            }
            fm_AlterarAmigo Alterar = new fm_AlterarAmigo();
            Alterar.Preencher(ModificaAmigo);
            Alterar.ShowDialog();

        }
        private void bt_Devolver_Click(object sender, EventArgs e)
        {
            devolver.ShowDialog();
        }

    }
}
